using AdventOfCode.Benchmarks.Sdk;
using AdventOfCode.Tasks.Sdk;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Runner.Utils.Commands;

namespace Runner.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTasks(this IServiceCollection services)
    {
        services.Scan(source => source.FromApplicationDependencies()
            .AddClasses(c => c.AssignableTo(typeof(ITasks<,>)))
            .As<ITasksMetadata>()
            .WithScopedLifetime());
        
        return services;
    }
    
    public static IServiceCollection AddBenchmarks(this IServiceCollection services)
    {
        services.Scan(source => source.FromApplicationDependencies()
            .AddClasses(c => c.AssignableTo<IBenchmark>())
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        
        return services;
    }
    
    public static IServiceCollection AddCommandBus(this IServiceCollection services)
    {
        services.AddTransient((Func<IServiceProvider, Func<Type, ICommandHandler>>)(serviceProvider =>
        {
            return (type) =>
            {
                var handlerType = typeof(ICommandHandler<>).MakeGenericType(type);
                return (ICommandHandler)serviceProvider.GetRequiredService(handlerType);
            };
        }));
        services.AddTransient((Func<IServiceProvider, Func<Type, IValidator?>>)(serviceProvider =>
        {
            return (type) =>
            {
                var validatorType = typeof(IValidator<>).MakeGenericType(type);
                return (IValidator?)serviceProvider.GetService(validatorType);
            };
        }));
        services.AddSingleton<CommandBus>();
        services.Scan(source => source.FromAssemblyOf<Program>()
            .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        services.Scan(source => source.FromAssemblyOf<Program>()
            .AddClasses(c => c.AssignableTo(typeof(AbstractValidator<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        
        return services;
    }
}
