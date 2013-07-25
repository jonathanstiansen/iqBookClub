using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1.Chapter_8
{
    public class SvnCommit : ICommit
    {
        private readonly string _format;

        public SvnCommit(string format)
        {
            _format = format;
        }

        public int CompareTo(ICommit other)
        {
            throw new NotImplementedException();
        }

        public DateTime date { get; private set; }
    }

    public interface ICommit : IComparable<ICommit>
    {
        DateTime date { get; }
    }

    public class GitCommit : ICommit
    {
        public GitCommit(string zx)
        {
        }

        public int CompareTo(ICommit other)
        {
            return date.CompareTo(other.date);
        }

        public DateTime date { get; private set; }
    }

    public class FakeLog<TCommit> : IFakeLog
        where TCommit : ICommit
    {
        private readonly List<TCommit> _commits;

        public FakeLog(IEnumerable<TCommit> commits)
        {
            _commits = commits.ToList();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AppendToLog(ICommit commit)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ICommit> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICommit> GetAll()
        {
            return null;
        }
    }


    public interface IFakeLog : IEnumerable<ICommit>
    {
        void AppendToLog(ICommit commit);
    }


    public class masterLog
    {
        public IEnumerable<ICommit> SortCommitsChronologically(IEnumerable<IFakeLog> logs)
        {
            //return logs.SelectMany(l => l.GetAll()).OrderBy(x => x);
            return null;
        }
    }
}