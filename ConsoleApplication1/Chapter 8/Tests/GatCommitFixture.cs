using System.Collections;
using NUnit.Framework;

namespace ConsoleApplication1.Chapter_9.Tests
{
    [TestFixture]
    internal class GatCommitFixture : VersionControlActionBaseFixture
    {
       

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

    }
}