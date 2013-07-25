using System.Collections;
using ConsoleApplication1.Chapter_9.Tests;

namespace ConsoleApplication1.Chapter_8.Tests
{
    public class GatVersionControlLogs : IVersionControlLog
    {
        private ArrayList _log;

        public GatVersionControlLogs()
        {
            _log = new ArrayList();
        }

        public void AddActionToLog(IVersionControlAction action)
        {
            _log.Add(action);
        }

        public ICollection GetAllActions()
        {
            return _log;
        }

        public IEnumerator GetEnumerator()
        {
            return _log.GetEnumerator();
        }

        public int Count
        {
            get { return _log.Count; }
        }
    }
}