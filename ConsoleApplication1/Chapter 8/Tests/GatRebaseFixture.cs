using System.Collections;
using ConsoleApplication1.Chapter_9.Tests;
using NUnit.Framework;

namespace ConsoleApplication1.Chapter_8.Tests
{
    [TestFixture]
    internal class GatRebaseFixture : VersionControlActionBaseFixture
    {
        /*Stage 1: Jonathan will talk about*/

        /*Stage 2*/

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


        /*Stage 3*/
//                [Test]
//                public void RebaseShouldReturnArrayWithLength()
//                {
//                    var RebaseAction = new GatRebaseToVersionControl("20130924", "First Rebase 001");
//                    ArrayList executionActions = RebaseAction.Execute();
//        
//                    Assert.IsTrue(executionActions.Count == 5);
//                }
//        
//                [Test]
//                public void SuccessfulRebaseShouldHaveMessages()
//                {
//                    var correctSuccessMessages = new ArrayList
//                        {
//                            "Logging",
//                            "Saving",
//                            "Running Gat Rebase",
//                            "Action Successful",
//                            "Action Completed",
//                            //Notice this is new to rebase, how can we efficiently make this happen?
//                            "Now Re-Writing History"
//                        };
//                    var RebaseAction = new GatRebaseToVersionControl("20130924", "First Rebase 001");
//                    ArrayList executionMessages = RebaseAction.Execute();
//        
//                    Assert.IsTrue(haveSameStringsAtSameIndex(correctSuccessMessages, executionMessages));
//                }
    }
}