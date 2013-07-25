using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ConsoleApplication1.Chapter_8.Tests;

namespace ConsoleApplication1.Chapter_9.Tests
{
    public class MasterVersionControl
    {
        private IVersionControlLog _firstLog;
        private IVersionControlLog _secondLog;

        public MasterVersionControl(IVersionControlLog firstLog, IVersionControlLog secondLog)
        {
            _firstLog = firstLog;
            _secondLog = secondLog;
        }
        // THis code is NOT comepletly working. 
        // It only currently handles cases where each log does not have more 
        // than 1 stringNumber that is greater than the other in a row.
        public List<IVersionControlAction> GetChronologicalListOfActions()
        {
            var result = new List<IVersionControlAction>();
            var firstEnum = _firstLog.GetEnumerator();
            var secondEnum = _secondLog.GetEnumerator();
            IVersionControlAction firstAction;
            IVersionControlAction secondAction;
            while (firstEnum.MoveNext())
            {
                firstAction = (IVersionControlAction) firstEnum.Current;
                if (secondEnum.MoveNext())
                {
                    secondAction = (IVersionControlAction)secondEnum.Current;
                    var firstStringNumber = Convert.ToInt32(firstAction.GetStringNumber);
                    var secondStringNumber = Convert.ToInt32(secondAction.GetStringNumber);
                    if (firstStringNumber > secondStringNumber)
                    {
                        result.Add(secondAction);
                        result.Add(firstAction);
                    } else {
                        result.Add(firstAction);
                        result.Add(secondAction);
                    }
                } else {
                    result.Add(firstAction);
                }
            }

            while(secondEnum.MoveNext())
            {
                secondAction = (IVersionControlAction)secondEnum.Current;
                result.Add(secondAction);
            }
            return result;
        }
    }
}