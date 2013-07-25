
using System.Collections.Generic;

namespace DesignPatternsProgram.Adapter
{
    class GatCommand : IGatCommand
    {
        public IList<IAction> CompletedActions { get; set; }

        public IEnumerable<IAction> AllActions { get; set; }

        public GatCommand(IEnumerable<IAction> allActions)
        {
            this.AllActions = allActions;
            this.CompletedActions = new List<IAction>();
        }

        public void Execute()
        {
            foreach (var action in AllActions)
            {
                action.Do();
                CompletedActions.Add(action);
            }
        }

        public void Rollback()
        {
            foreach (var completedAction in CompletedActions)
            {
                completedAction.Undo();
            }
        }
    }
}
