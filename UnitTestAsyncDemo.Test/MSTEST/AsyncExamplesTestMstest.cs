using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Fakes;
using Microsoft.QualityTools.Testing.Fakes;

namespace UnitTestAsyncDemo.Test.Mstest
{
    [TestClass]
    public class AsyncExamplesTestMstest
    {
        // always return Task in async, never use async void.. this is bad bad bad
        [TestMethod]
        [TestProperty("Time", "Long")]
        public async Task AsyncSleepTimerTest()
        {
            var asyncMethod = new AsyncExamples();

            await asyncMethod.SomeLongRunningSleep();

            Assert.AreEqual("Hello World", asyncMethod.TestProperty);
        }

        [TestMethod]
        [ExpectedException(typeof(Y2KException))]
        public void EndOfWorldCheckerTest()
        {
            // scope the shim otherwise it will fail, this is so it does not last forever.
            using (ShimsContext.Create())
            {
                var asyncClass = new AsyncExamples();
                ShimDateTime.NowGet = () => new DateTime(2000, 1, 1);
                asyncClass.CheckIfEndOfWorld();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Y2KException))]
        public void EndOfWorldCheckerPrivTest()
        {
            // scope the shim otherwise it will fail, this is so it does not last forever.
            using (ShimsContext.Create())
            {
                AsyncExamples asyncEx = new AsyncExamples();
                PrivateObject y2K = new PrivateObject(asyncEx);
                ShimDateTime.NowGet = () => new DateTime(2000, 1, 1);

                y2K.Invoke("CheckIfEndOfWorldPrivateMethod");

                //var asyncClass = new AsyncExamples();
                //ShimDateTime.NowGet = () => new DateTime(2000, 1, 1);
                //asyncClass.CheckIfEndOfWorld();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Y2KException))]
        public void EndOfWorldCheckerProTest()
        {
            // scope the shim otherwise it will fail, this is so it does not last forever.
            using (ShimsContext.Create())
            {
                AsyncExamples asyncEx = new AsyncExamples();
                PrivateObject y2K = new PrivateObject(asyncEx);
                ShimDateTime.NowGet = () => new DateTime(2000, 1, 1);

                y2K.Invoke("CheckIfEndOfWorldProtectedMethod");

                //var asyncClass = new AsyncExamples();
                //ShimDateTime.NowGet = () => new DateTime(2000, 1, 1);
                //asyncClass.CheckIfEndOfWorld();
            }
        }

    }
}
