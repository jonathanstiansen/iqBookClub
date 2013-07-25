using System.Collections.Generic;

namespace DesignPatternsProgram.Adapter
{
    public interface IGatCommand
    {
        IList<IAction> CompletedActions { get; set; }
        IEnumerable<IAction> AllActions { get; set; }
        void Execute();
        void Rollback();
    }
}