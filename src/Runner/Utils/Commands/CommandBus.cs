using System.Reflection;

namespace Runner.Utils.Commands;

public class CommandBus
{
    private readonly Func<Type, ICommandHandler> handlersFactory;

    public CommandBus(Func<Type, ICommandHandler> handlersFactory)
    {
        this.handlersFactory = handlersFactory;
    }
    
    public void Send<TCommand>(TCommand command) where TCommand : class, ICommand
    {
        var commandType = command.GetType();
        var handler = handlersFactory(commandType);
        var handle = GetMethod(typeof(ICommandHandler<>), commandType, nameof(ICommandHandler<TCommand>.Handle));

        handle.Invoke(handler, new object[] { command });
    }

    private MethodInfo GetMethod(Type genericType, Type commandType, string methodName) =>
        genericType.MakeGenericType(commandType).GetMethod(methodName) ?? throw new InvalidOperationException();
}
