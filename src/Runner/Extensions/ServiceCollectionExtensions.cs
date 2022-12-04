using AdventOfCode.Tasks.Sdk;
using Microsoft.Extensions.DependencyInjection;
using Runner.Utils.Commands;

namespace Runner.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTasks(this IServiceCollection services)
    {
        services.Scan(source => source.FromApplicationDependencies()
            .AddClasses(c => c.AssignableTo<ITasks>())
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
        services.AddSingleton<CommandBus>();
        services.Scan(source => source.FromAssemblyOf<Program>()
            .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        
        return services;
    }
}
