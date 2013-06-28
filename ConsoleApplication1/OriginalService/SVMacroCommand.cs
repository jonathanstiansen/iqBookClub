using System.Collections.Generic;
using System.Text;
using DesignPatternsProgram;

namespace ConsoleApplication1.OriginalService
{
    public class SvMacroCommand : ISVMCommand
    {
        private readonly IEnumerable<ISVMCommand> _commands;

        public SvMacroCommand(IEnumerable<ISVMCommand> commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var svmCommand in _commands)
            {
                svmCommand.Execute();
            }
        }

        public string GetChangesMade()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("Commands:");
            foreach (var svmCommand in _commands)
            {
                stringBuilder.AppendLine(svmCommand.GetChangesMade());
            }
            stringBuilder.Append(" were completed...")
            return stringBuilder.ToString();
        }
    }
}