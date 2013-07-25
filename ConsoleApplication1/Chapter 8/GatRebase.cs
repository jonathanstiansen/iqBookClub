using System;
using System.Collections;

namespace ConsoleApplication1.Chapter_9.Tests
{
    public class GatRebaseToVersionControl : IVersionControlAction
    {
        public string GetStringNumber { get; set; }

        public virtual ArrayList Execute()
        {
            throw new NotImplementedException();
        }
    }
}