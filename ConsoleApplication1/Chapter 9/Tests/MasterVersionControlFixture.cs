using ConsoleApplication1.Chapter_9.Tests;
using NUnit.Framework;

namespace ConsoleApplication1.Chapter_8.Tests
{
    [TestFixture]
    public class MasterVersionControlFixture
    {
        private MasterVersionControl _masterControl ;
        private GatVersionControlLogs _gatLogs ;
        private SvmLogginSystem _svmLogs;
        private GatCommitToVersionControl gatAction;
        private SvmVersionControlAction svmAction;
        private GatCommitToVersionControl gatAction2;


        [SetUp]
        public void SetUp()
        {
            _gatLogs = new GatVersionControlLogs();
            _svmLogs = new SvmLogginSystem();
            _masterControl = new MasterVersionControl(_gatLogs, _svmLogs);
            gatAction = new GatCommitToVersionControl("20130102", "Commiting first");
            svmAction = new SvmVersionControlAction("01012013");
            gatAction2 = new GatCommitToVersionControl("20130130", "Commiting second");

            _svmLogs.AddActionToLog(svmAction);
            _gatLogs.AddActionToLog(gatAction);
            _gatLogs.AddActionToLog(gatAction2);
        }

        [Test]
        public void ShouldBeAbleToGetAllActions()
        {
            var chronoActions = _masterControl.GetChronologicalListOfActions();
           
            Assert.IsTrue(chronoActions.Contains(gatAction));
            Assert.IsTrue(chronoActions.Contains(gatAction2));
            Assert.IsTrue(chronoActions.Contains(svmAction));
        }

        [Test]
        public void ShouldReturnChronologicalActionsInCorrectOrder()
        {
            var chronoActions = _masterControl.GetChronologicalListOfActions();

            var actionEnumerator = chronoActions.GetEnumerator();
            var action1 = actionEnumerator.Current;
            actionEnumerator.MoveNext();
            var action2 = actionEnumerator.Current;
            actionEnumerator.MoveNext();
            var action3 = actionEnumerator.Current;
            actionEnumerator.MoveNext();

            Assert.IsTrue(action1 == svmAction);
            Assert.IsTrue(action2 == gatAction);
            Assert.IsTrue(action3 == gatAction2);
        }
    }
}