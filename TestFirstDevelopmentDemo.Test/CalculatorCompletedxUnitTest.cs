namespace TestFirstDevelopmentDemo.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TestFirstDevelopmentDemo;

    // using Xunit;
    using Xunit.Extensions;

    using Assert = Xunit.Assert;

    [TestClass]
    public class CalculatorCompletedxUnitTest
    {
        // Arrange
        private readonly CalculatorCompleted cal;

        public CalculatorCompletedxUnitTest()
        {
            cal = new CalculatorCompleted();
        }

        // [Fact]
        [TestMethod]
        public void CalculatorEmptyStringTest()
        {
            // Act
            var returnValue = cal.Calculator(string.Empty);

            // Assert
            Assert.Equal(0, returnValue);
        }

        [Theory,
            InlineData(0, ""),
            InlineData(3, "1,2"),
            InlineData(6, "1,2,3"),
            InlineData(3, @"1\n2")]
        public void CalculatorTheoryTest(int expectedReturn, string passedInValue)
        {
            // Act
            var returnValue = cal.Calculator(passedInValue);

            // Assert
            Assert.Equal(expectedReturn, returnValue);
        }
    }
}
