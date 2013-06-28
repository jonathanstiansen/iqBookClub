using DesignPatternsProgram.Adapter;

namespace DesignPatternsProgram
{
    public class GatToSvmAdapter : ISVMCommand
    {
        private IGatCommand _gatCommand;

        public GatToSvmAdapter(IGatCommand gatCommand)
        {
            _gatCommand = gatCommand;
        }

        public void Execute()
        {
            _gatCommand.Execute();
        }

        public string GetChangesMade()
        {
            return _gatCommand.CompletedActions.ToString();
        }
    }
}