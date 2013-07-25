using System.Collections;

namespace ConsoleApplication1.Chapter_9.Tests
{
    public interface IVersionControlAction
    {
        string GetStringNumber { get; set; }
        ArrayList Execute();
    }
}