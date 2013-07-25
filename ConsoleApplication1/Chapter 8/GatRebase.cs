using System;
using System.Collections;

namespace ConsoleApplication1.Chapter_9.Tests
{
    public class GatRebaseToVersionControl : GatVersionControlAction
    {
        public GatRebaseToVersionControl(string yyyymmddDate, string message, string getStringNumber) : base(yyyymmddDate, message)
        {
            GetStringNumber = getStringNumber;
        }

        public GatRebaseToVersionControl(string yyyymmddDate, string firstRebase) : base(yyyymmddDate, firstRebase)
        {
            throw new NotImplementedException();
        }

        public string GetStringNumber { get; set; }

        public virtual ArrayList Execute()
        {
            throw new NotImplementedException();
        }
    }
}