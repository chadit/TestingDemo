namespace StringCalculatorAsyncTestXunit
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using StringCalculatorAsync;
    using Xunit;
    using Xunit.Extensions;

    public class AsyncCalculatorDemoCompleteXunit
    {
        // Arrange
        private readonly AsyncCalculatorDemoComplete cal;

        public AsyncCalculatorDemoCompleteXunit()
        {
            cal = new AsyncCalculatorDemoComplete();
        }

        [Theory,
            InlineData(0, ""),
            InlineData(3, "1,2"),
            InlineData(6, "1,2,3"),
            InlineData(3, @"1\n2")]
        public async Task AsyncCalculatorEmptyStringTest(int expectedReturn, string passedInValue)
        {
            // Act
            await this.cal.Calculator(passedInValue);

            // Assert
            Assert.Equal(expectedReturn, cal.CalculatedValue);
        }
    }
}
