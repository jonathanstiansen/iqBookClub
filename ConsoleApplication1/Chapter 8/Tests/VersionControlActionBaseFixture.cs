using System.Collections;

namespace ConsoleApplication1.Chapter_9.Tests
{
    public class VersionControlActionBaseFixture
    {
        // Helper Method
        protected bool haveSameStringsAtSameIndex(ArrayList list1, ArrayList list2)
        {
            bool haveSameElements = list1.Count == list2.Count;
            for (int i = 0; i < list1.Count; ++i)
            {
                bool sameItemAtIndexI = list1.IndexOf(i) == list2.IndexOf(i);
                haveSameElements = haveSameElements && sameItemAtIndexI;
            }
            return haveSameElements;
        }
    }
}