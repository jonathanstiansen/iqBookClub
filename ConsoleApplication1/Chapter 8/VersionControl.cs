using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter_9.Tests
{
    public class VersionControl
    {
        private ArrayList _versionControlActions;

        public VersionControl(IVersionControlAction firstAction, IVersionControlAction secondAction)
        {
            _versionControlActions = new ArrayList();
            _versionControlActions.Add(firstAction);
            _versionControlActions.Add(secondAction);
        }

        public void appendCompletedAction(IVersionControlAction completedAction)
        {
            _versionControlActions.Add(completedAction);
        }

        public void addListOfActionsChronolically(IEnumerable<IVersionControlAction> iterableCollectionOfActions)
        {
            
        }
    }
}