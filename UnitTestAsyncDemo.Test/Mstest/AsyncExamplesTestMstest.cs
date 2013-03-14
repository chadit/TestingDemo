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
    }
}
