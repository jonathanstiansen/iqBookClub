namespace DesignPatternsProgram
{
    public interface ICommandService
    {
        void ExecuteCommand(string commandName);
        void AddCommand(string name, ISVMCommand command);
    }
}