namespace DesignPatternsProgram.Adapter
{
    public interface IAction
    {
        string Do();
        void Undo();
    }
}