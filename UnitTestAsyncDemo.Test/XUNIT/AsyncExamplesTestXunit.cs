using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestAsyncDemo.Test.Xunit
{
    public class AsyncExamplesTestXunit
    {
        // always return Task in async, never use async void.. this is bad bad bad
        [Fact]
        public async Task AsyncSleepTimerTest()
        {
            var asyncMethod = new AsyncExamples();

            await asyncMethod.SomeLongRunningSleep();

            Assert.Equal("Hello World", asyncMethod.TestProperty);
        }
    }
}
