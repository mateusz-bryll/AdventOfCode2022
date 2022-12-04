using System.Reflection;
using FluentValidation;

namespace Runner.Utils.Commands;

public class CommandBus
{
    private readonly Func<Type, IValidator?> validatorsFactory;
    private readonly Func<Type, ICommandHandler> handlersFactory;

    public CommandBus(Func<Type, IValidator> validatorsFactory, Func<Type, ICommandHandler> handlersFactory)
    {
        this.validatorsFactory = validatorsFactory;
        this.handlersFactory = handlersFactory;
    }
    
    public void Send<TCommand>(TCommand command) where TCommand : class, ICommand
    {
        var commandType = command.GetType();
        
        var context = new ValidationContext<TCommand>(command);
        var commandValidator = validatorsFactory(commandType);
        if (commandValidator != null)
        {
            var validationResult = commandValidator.Validate(context);
            if (!validationResult.IsValid)
            {
                foreach (var failure in validationResult.Errors)
                {
                    Console.WriteLine($"[{failure.ErrorCode}]: ({failure.PropertyName}={failure.AttemptedValue}) {failure.ErrorMessage}");
                }
                return;
            }
        }
        
        var handler = handlersFactory(commandType);
        var handle = GetMethod(typeof(ICommandHandler<>), commandType, nameof(ICommandHandler<TCommand>.Handle));

        handle.Invoke(handler, new object[] { command });
    }

    private MethodInfo GetMethod(Type genericType, Type commandType, string methodName) =>
        genericType.MakeGenericType(commandType).GetMethod(methodName) ?? throw new InvalidOperationException();
}
