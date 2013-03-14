using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAsyncDemo.Test.Mstest
{
    [TestClass]
    public class AsyncExamplesTestMstest
    {
        // always return Task in async, never use async void.. this is bad bad bad
        [TestMethod]
        public async Task AsyncSleepTimerTest()
        {
            var asyncMethod = new AsyncExamples();

            await asyncMethod.SomeLongRunningSleep();

            Assert.AreEqual("Hello World", asyncMethod.TestProperty);
        }
    }
}
