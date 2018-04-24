namespace ProjetoEstoque.Command
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }

    public interface ICommandHandler<in TCommand, out TCommandResult> where TCommand : ICommand
    {
        TCommandResult Handle(TCommand command);
    }
}
