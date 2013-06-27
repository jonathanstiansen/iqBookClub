using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MySuperCoolVersionControl
    {
        static void Main(string[] args)
        {
            var x = new Dictionary<string, ISVMCommand>
                {
                    {"cmd1", new SomeSVMCommand()}
                };

            x[args[1]].Execute();
        }
    }
}
