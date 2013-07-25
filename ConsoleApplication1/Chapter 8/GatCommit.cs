using System;

namespace ConsoleApplication1.Chapter_9.Tests
{
    public class GatCommitToVersionControl : IVersionControlAction
    {
        private readonly string _date;
        private readonly string _message;

        public bool Completed { get; private set; }

        private string ActionName
        {
            get { return "Gat Commit"; } 
        }

        public GatCommitToVersionControl(string yyyymmddDate, string message)
        {
            _date = yyyymmddDate;
            _message = message;
            Completed = false;
        }

        public void Execute()
        {
            LogAction();
            BackupState();
            RunAction();
            if (!CompletesSuccessfully())
            {
                Rollback();
            } else {
                Completed = true;
                Console.WriteLine("Completed " + ActionName +": " + _message + " on " + _date);
            }
        }

        private void BackupState()
        {
            Console.WriteLine("Failed, reverting");
        }

        private void LogAction()
        {
            Console.WriteLine("Starting: " + ActionName);
        }

        private void RunAction()
        {
            Console.WriteLine("Running " + ActionName);
        }

        private void Rollback()
        {
            Console.WriteLine("Rolling back: " + ActionName);
        }

        private bool CompletesSuccessfully()
        {
            return _date.Length == 8 && _message.Length > 0;
        }

       
    }
}