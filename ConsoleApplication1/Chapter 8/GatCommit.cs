using System;
using System.Collections;

namespace ConsoleApplication1.Chapter_9.Tests
{
    public class GatCommitToVersionControl : GatVersionControlAction
    {
        public GatCommitToVersionControl(string yyyymmddDate, string message) : base(yyyymmddDate, message)
        {
        }
    }
}