namespace DesignPatternsProgram
{
    public interface ISVMCommand
    {
        void Execute();
        string GetChangesMade();

    }
}