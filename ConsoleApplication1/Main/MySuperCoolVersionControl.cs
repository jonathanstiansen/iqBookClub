using System.Collections.Generic;
using ConsoleApplication1.OriginalService;
using DesignPatternsProgram;
using DesignPatternsProgram.Adapter;
using DesignPatternsProgram.OriginalService;

namespace ConsoleApplication1.Main
{
    internal class MySuperCoolVersionControl
    {
        // From the command line
        // $ myscvc someCoolName cmd1 cmd2
        // args[0] -> name
        // args[1+] space seperated command names to run when a given name is entered
        // When args.length is 1 run that command
        private static void Main(string[] args)
        {
            var commandService = setUpCommandService();
            var commandNameEntered = args[0];
            switch (args.Length)
            {
                case 0:
                    commandService.ExecuteCommand(commandNameEntered);
                    break;
                case 1:
                    var commandToBind = commandService.GetCommand(args[1]);
                    commandService.AddCommand(commandNameEntered, commandToBind);
                    break;
                default:
                    var commandList = GetListOfCommands(args, commandService);
                    var commandsToBind = new SvMacroCommand(commandList);
                    commandService.AddCommand(commandNameEntered, commandsToBind);
                    break;
            }
        }

        private static SvmCommandService setUpCommandService()
        {
            var someSvmCommand = new SomeSVMCommand();
            var someOtherSvmCommand = new SomeSVMCommand();
            var anAction = new Action("OMG, MY FIRST ACTION");
            var anotherAction = new Action("The not-as-exciting second action...");
            var anotherAnotherAction = new Action("getting old...");
            var actionList = new List<IAction>
                {
                    anAction,
                    anotherAction,
                    anotherAnotherAction
                };
            var previouslyAGatCommand = new GatToSvmAdapter(
                new GatCommand(actionList)
                );
            var previouslyAsvnnCommand = new BastardizedSVNNAdapter(new BastardSvnnCommand());
            var svMacroCommand = new SvMacroCommand(
                new List<ISVMCommand>
                    {someSvmCommand, previouslyAGatCommand, someOtherSvmCommand}
                );
            var commandService = new SvmCommandService(new Dictionary<string, ISVMCommand>
                {
                    {"cmd1", someSvmCommand},
                    {"cmd2", someOtherSvmCommand},
                    {"gatCmd", previouslyAGatCommand},
                    {"bastardCommand", previouslyAsvnnCommand},
                    {"macroCommand", svMacroCommand}
                });
            return commandService;
        }

        private static IEnumerable<ISVMCommand> GetListOfCommands(string[] args, SvmCommandService commandService)
        {
            var commandList = new List<ISVMCommand>();

            for (var i = 1; i < args.Length; i++)
            {
                commandList.Add(commandService.GetCommand(args[i]));
            }
            return commandList;
        }
    }
}