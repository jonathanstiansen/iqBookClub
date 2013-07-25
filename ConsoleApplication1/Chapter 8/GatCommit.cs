using System;
using System.Collections;

namespace ConsoleApplication1.Chapter_9.Tests
{
    public class GatCommitToVersionControl : IVersionControlAction
    {
        private readonly string _date;
        private readonly string _message;
        private ArrayList _completedParts;

        public GatCommitToVersionControl(string yyyymmddDate, string message)
        {
            _date = yyyymmddDate;
            GetStringNumber = yyyymmddDate;
            _message = message;
            Completed = false;
        }

        public bool Completed { get; private set; }

        public string GetStringNumber { get; set; }

        public ArrayList Execute()
        {
            if (!Completed)
            {
                _completedParts = new ArrayList();
                LogAction();
                BackupState();
                RunAction();
                if (!CompletesSuccessfully())
                {
                    Rollback();
                }
                else
                {
                    Completed = true;
                    _completedParts.Add("Action Completed");
                }
            }
            return _completedParts;
        }

        private void LogAction()
        {
            _completedParts.Add("Logging");
        }

        private void BackupState()
        {
            _completedParts.Add("Saving");
        }

        private void RunAction()
        {
            _completedParts.Add("Running Gat Commit");
        }

        private void Rollback()
        {
            _completedParts.Add("Rolling back");
            _completedParts.Add("State Restored");

        }

        private bool CompletesSuccessfully()
        {
            bool completesSuccessfully = _date.Length == 8 && _message.Length > 0;
            _completedParts.Add(completesSuccessfully ? "Action Successful" : "Action Failed");

            return completesSuccessfully;
        }
    }
}