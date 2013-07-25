using System.Collections;
using ConsoleApplication1.Chapter_9.Tests;

namespace ConsoleApplication1.Chapter_8.Tests
{
    public interface IVersionControlLog : IEnumerable
    {
        void AddActionToLog(IVersionControlAction action);
        ICollection GetAllActions();
        int Count { get; }
    }
}