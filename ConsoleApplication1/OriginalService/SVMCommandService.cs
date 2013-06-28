using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPatternsProgram.OriginalService
{
    public class SvmCommandService : ICommandService
    {
        private readonly Dictionary<string, ISVMCommand> _commandDictionary;

        public SvmCommandService(Dictionary<string, ISVMCommand> commandDictionary)
        {
            _commandDictionary = commandDictionary;
        }

        public void ExecuteCommand(string commandName)
        {
            Debug.Assert(commandName != null, "commandName != null");
            _commandDictionary[commandName].Execute();
        }

        public void AddCommand(string name, ISVMCommand command)
        {
            _commandDictionary.Add(name, command);
        }

        public ISVMCommand GetCommand(string name)
        {
            return _commandDictionary[name];
        }
    }
}