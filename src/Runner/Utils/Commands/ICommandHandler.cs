namespace Runner.Utils.Commands;

public interface ICommandHandler
{
}

public interface ICommandHandler<in TCommand> : ICommandHandler
    where TCommand : class, ICommand
{
    public void Handle(TCommand command);
}
