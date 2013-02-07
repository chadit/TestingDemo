namespace TestFirstDevelopmentDemo.Test
{
    using Xunit;

    public class CalculatorCompletedxUnitTest
    {
        // Arrange
        private readonly CalculatorCompleted cal;

        public CalculatorCompletedxUnitTest()
        {
            cal = new CalculatorCompleted();
        }

        [Fact]
        public void CalculatorTestEmptyString()
        {
            // Act
            var returnValue = cal.Calculator(string.Empty);

            // Assert
            Assert.Equal(0, returnValue);
        }

    }
}
