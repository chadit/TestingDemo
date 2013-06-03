using System;
using System.Fakes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.QualityTools.Testing.Fakes;
using Xunit;

namespace UnitTestAsyncDemo.Test.Xunit
{
    public class AsyncExamplesTestXunit
    {
        // always return Task in async, never use async void.. this is bad bad bad
        [Fact]
        public async Task XunitAsyncSleepTimerTest()
        {
            var asyncMethod = new AsyncExamples();

            await asyncMethod.SomeLongRunningSleep();

            Assert.Equal("Hello World", asyncMethod.TestProperty);
        }


        [Fact]
        public void XunitEndOfWorldCheckerTest()
        {
            // scope the shim otherwise it will fail, this is so it does not last forever.
            using (ShimsContext.Create())
            {
                var asyncClass = new AsyncExamples();
                ShimDateTime.NowGet = () => new DateTime(2001, 1, 1);
                // asyncClass.CheckIfEndOfWorld();
                Assert.Throws<Y2KException>(() => asyncClass.CheckIfEndOfWorld());
            }
        }
    }
}
