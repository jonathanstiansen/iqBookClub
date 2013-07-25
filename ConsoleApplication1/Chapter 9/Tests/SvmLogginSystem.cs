using System.Collections;
using ConsoleApplication1.Chapter_9.Tests;

namespace ConsoleApplication1.Chapter_8.Tests
{
    public class SvmLogginSystem : IVersionControlLog
    {
        private Hashtable _log;
        private int _commitNumber;

        public SvmLogginSystem()
        {
            _commitNumber = 0;
            _log = new Hashtable();
        }

        public void AddActionToLog(IVersionControlAction action)
        {
            _log.Add(_commitNumber, action);
            _commitNumber++;
        }

        public ICollection GetAllActions()
        {
            return _log.Values;
        }

        public int Count
        {
            get { return _log.Values.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return _log.Values.GetEnumerator();
        }
    }
}