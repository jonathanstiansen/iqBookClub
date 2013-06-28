using System;

namespace DesignPatternsProgram
{
    public class BastardizedSVNNAdapter : ISVMCommand
    {
        private IBastardSVNNCommand _svnnCommand;

        public BastardizedSVNNAdapter(IBastardSVNNCommand svnnCommand)
        {
            _svnnCommand = svnnCommand;
        }
        public void Execute()
        {
            _svnnCommand.ExeeecuteOrDie();
        }

        public string GetChangesMade()
        {
            throw new Exception("Incompatible function");
        }
    }
}