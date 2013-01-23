namespace TestFirstDevelopmentDemo.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CalculatorBuildTest
    {
        // Arrange
        private CalculatorBuild cal;

        [TestInitialize]
        public void Setup()
        {
            cal = new CalculatorBuild();
        }
    }
}
