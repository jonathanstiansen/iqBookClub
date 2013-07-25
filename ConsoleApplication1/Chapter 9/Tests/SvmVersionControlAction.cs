using System.Collections;
using ConsoleApplication1.Chapter_9.Tests;

namespace ConsoleApplication1.Chapter_8.Tests
{
    public class SvmVersionControlAction : IVersionControlAction
    {
        public SvmVersionControlAction(string ddmmyyyyDate)
        {
            GetStringNumber = ddmmyyyyDate;
        }

        public string GetStringNumber { get; set; }

        public ArrayList Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}