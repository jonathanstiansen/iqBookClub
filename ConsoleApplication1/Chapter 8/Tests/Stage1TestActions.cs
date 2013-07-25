using System.Collections;
using NUnit.Framework;

namespace ConsoleApplication1.Chapter_9.Tests
{
    [TestFixture]
    internal class Stage1TestActions
    {
        // Helper Method
        private bool haveSameStringsAtSameIndex(ArrayList list1, ArrayList list2)
        {
            bool haveSameElements = list1.Count == list2.Count;
            for (int i = 0; i < list1.Count; ++i)
            {
                bool sameItemAtIndexI = list1.IndexOf(i) == list2.IndexOf(i);
                haveSameElements = haveSameElements && sameItemAtIndexI;
            }
            return haveSameElements;
        }

        [Test]
        public void CommitShouldFailIfNotRun()
        {
            var commitAction = new GatCommitToVersionControl("20130924", "First Commit 001");

            Assert.IsFalse(commitAction.Completed);
        }

        [Test]
        public void CommitShouldPassIfExecutedWithMessageAndDate()
        {
            var commitAction = new GatCommitToVersionControl("20130924", "First Commit 001");
            commitAction.Execute();

            Assert.IsTrue(commitAction.Completed);
        }

        [Test]
        public void CommitShouldReturnArrayWithLength()
        {
            var commitAction = new GatCommitToVersionControl("20130924", "First Commit 001");
            ArrayList executionActions = commitAction.Execute();

            Assert.IsTrue(executionActions.Count == 5);
        }

        [Test]
        public void FailedCommitShouldHaveMessages()
        {
            var correctFailedMessages = new ArrayList
                {
                    "Logging",
                    "Saving",
                    "Running Gat Commit",
                    "Action Failed",
                    "Rolling Back",
                    "State Restored"
                };
            var commitAction = new GatCommitToVersionControl("", "First Commit 001");
            ArrayList executionMessages = commitAction.Execute();

            Assert.IsTrue(haveSameStringsAtSameIndex(correctFailedMessages, executionMessages));
        }

        [Test]
        public void FailedCommitShouldReturnArrayWithLength()
        {
            var commitAction = new GatCommitToVersionControl("", "First Commit 001");
            ArrayList executionActions = commitAction.Execute();

            Assert.IsTrue(executionActions.Count == 6);
        }

        [Test]
        public void SuccessfulCommitShouldHaveMessages()
        {
            var correctSuccessMessages = new ArrayList
                {
                    "Logging",
                    "Saving",
                    "Running Gat Commit",
                    "Action Successful",
                    "Action Completed"
                };
            var commitAction = new GatCommitToVersionControl("20130924", "First Commit 001");
            ArrayList executionMessages = commitAction.Execute();

            Assert.IsTrue(haveSameStringsAtSameIndex(correctSuccessMessages, executionMessages));
        }
        //Stage 1: Jonathan will talk about
   
        // Stage 2
//        [Test]
//        public void RebaseShouldFailIfNotRun()
//        {
//            var RebaseAction = new GatRebaseToVersionControl("20130924", "First Rebase 001");
//
//            Assert.IsFalse(RebaseAction.Completed);
//        }
//
//        [Test]
//        public void RebaseShouldPassIfExecutedWithMessageAndDate()
//        {
//            var RebaseAction = new GatRebaseToVersionControl("20130924", "First Rebase 001");
//            RebaseAction.Execute();
//
//            Assert.IsTrue(RebaseAction.Completed);
//        }
//
//        [Test]
//        public void FailedRebaseShouldReturnArrayWithLength()
//        {
//            var RebaseAction = new GatRebaseToVersionControl("", "First Rebase 001");
//            ArrayList executionActions = RebaseAction.Execute();
//
//            Assert.IsTrue(executionActions.Count == 6);
//        }
//
//
//        [Test]
//        public void FailedRebaseShouldHaveMessages()
//        {
//            var correctFailedMessages = new ArrayList
//                {
//                    "Logging",
//                    "Saving",
//                    "Running Gat Rebase",
//                    "Action Failed",
//                    "Rolling Back",
//                    "State Restored"
//                };
//            var RebaseAction = new GatRebaseToVersionControl("", "First Rebase 001");
//            ArrayList executionMessages = RebaseAction.Execute();
//
//            Assert.IsTrue(haveSameStringsAtSameIndex(correctFailedMessages, executionMessages));
//        }
//Stage 3
//        [Test]
//        public void RebaseShouldReturnArrayWithLength()
//        {
//            var RebaseAction = new GatRebaseToVersionControl("20130924", "First Rebase 001");
//            ArrayList executionActions = RebaseAction.Execute();
//
//            Assert.IsTrue(executionActions.Count == 5);
//        }
//
//        [Test]
//        public void SuccessfulRebaseShouldHaveMessages()
//        {
//            var correctSuccessMessages = new ArrayList
//                {
//                    "Logging",
//                    "Saving",
//                    "Running Gat Rebase",
//                    "Action Successful",
//                    "Action Completed",
//                    //Notice this is new to rebase, how can we efficiently make this happen?
//                    "Now Re-Writing History"
//                };
//            var RebaseAction = new GatRebaseToVersionControl("20130924", "First Rebase 001");
//            ArrayList executionMessages = RebaseAction.Execute();
//
//            Assert.IsTrue(haveSameStringsAtSameIndex(correctSuccessMessages, executionMessages));
//        }
    }
}