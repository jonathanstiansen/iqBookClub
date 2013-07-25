using NUnit.Framework;

namespace ConsoleApplication1.Chapter_9.Tests
{
    [TestFixture]
    class Stage1TestActions
    {
        [Test]
        public void CommitShouldPassIfExecutedWithMessageAndDate()
        {
            var commitAction = new GatCommitToVersionControl("20130924","First Commit 001");
            commitAction.Execute();
            Assert.IsTrue(commitAction.Completed);
        }        
        [Test]
        public void CommitShouldFailIfNotRun()
        {
            var commitAction = new GatCommitToVersionControl("20130924", "First Commit 001");
            Assert.IsFalse(commitAction.Completed);
        }

        [Test]
        public void RebaseShouldPassIfRun()
        {
            var rebaseAction = new GatRebaseToVersionControl("20130921", "First Rebase");
            rebaseAction.Execute();
            Assert.IsTrue(rebaseAction.Completed);
        }  
      
        [Test]
        public void RebaseShouldFailIfRun()
        {
            var rebaseAction = new GatRebaseToVersionControl("20130921", "First Rebase");
            Assert.IsFalse(rebaseAction.Completed);
        }

        /** Stage 1**/
        /** unComment when ready

        [Test]
        public void PushShouldPassIfRun()
        {
            var pushAction = new GatPushToVersionControl("20130921", "Pushing Commits");
            pushAction.Execute();
            Assert.IsTrue(pushAction.Completed);
        }

        [Test]
        public void PushShouldFailIfRun()
        {
            var pushAction = new GatPushToVersionControl("20130921", "Pushing Commits");
            Assert.IsFalse(pushAction.Completed);
        }
         
        [Test]
        public void PullShouldPassIfRun()
        {
            var pullAction = new GatPullToVersionControl("20130921", "Pull Commits");
            pullAction.Execute();
            Assert.IsTrue(pullAction.Completed);
        }

        [Test]
        public void PullShouldFailIfRun()
        {
            var pullAction = new GatPullToVersionControl("20130921", "Pulling Commits");
            Assert.IsFalse(pullAction.Completed);
        }

         **/

      
    }

    // Can't commit within 1 day of each other
}
