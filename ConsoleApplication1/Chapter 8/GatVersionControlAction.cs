using System.Collections;

namespace ConsoleApplication1.Chapter_9.Tests
{
    public abstract class GatVersionControlAction : IVersionControlAction
    {
        public bool Completed { get; private set; }
        public string GetStringNumber { get; set; }
        private readonly string _date;
        private readonly string _message;
        private ArrayList _completedParts;

        public ArrayList Execute()
        {
            throw new System.NotImplementedException();
        }
        public void LogAction()
        {
            throw new System.NotImplementedException();            
        }
        public void BackupState()
        {
            throw new System.NotImplementedException();            
        }
        public void RunAction()
        {
            throw new System.NotImplementedException();            
        }

        public void Rollback()
        {
            throw new System.NotImplementedException();                        
        }

        public bool CompletesSuccessfully()
        {
            throw new System.NotImplementedException();                        
        }



    }
}