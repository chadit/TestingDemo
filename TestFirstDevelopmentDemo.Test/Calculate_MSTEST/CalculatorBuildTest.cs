namespace TestFirstDevelopmentDemo.Test.Calculate_MSTEST
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
            this.cal = new CalculatorBuild();
        }



    }
}
