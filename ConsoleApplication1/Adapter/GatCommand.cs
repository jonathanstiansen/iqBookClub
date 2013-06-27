using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Adapter
{
    class GatCommand : IGatCommand
    {
        IEnumerable<IAction> completedActions;
        IEnumerable<IAction> allActions;

        

    }

    internal interface IGatCommand
    {
        void Execute();
        void Rollback();
    }
}
