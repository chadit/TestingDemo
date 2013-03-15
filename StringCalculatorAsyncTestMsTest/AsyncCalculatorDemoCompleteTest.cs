namespace StringCalculatorAsyncTestMsTest
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StringCalculatorAsync;

    [TestClass]
    public class AsyncCalculatorDemoCompleteTest
    {
        // Arrange
        private AsyncCalculatorDemoComplete cal;

        [TestInitialize]
        public void Setup()
        {
            this.cal = new AsyncCalculatorDemoComplete();
        }

        [TestMethod]
        public async Task AsyncCalculatorEmptyStringTest()
        {
            // Act
            await this.cal.Calculator(string.Empty);

            // Assert
            Assert.AreEqual(0, cal.CalculatedValue);
        }

        [TestMethod]
        public async Task AsyncCalculatorTwoNumberStringTest()
        {
            // Act
            await this.cal.Calculator("1,2");

            // Assert
            Assert.AreEqual(3, cal.CalculatedValue);
        }

        [TestMethod]
        public async Task AsyncCalculatorThreeNumberStringTest()
        {
            // Act
            await this.cal.Calculator("1,2,3");

            // Assert
            Assert.AreEqual(6, cal.CalculatedValue);
        }

        [TestMethod]
        public async Task AsyncCalculatorNewLineDelimeterTest()
        {
            // Act
            await this.cal.Calculator(@"1\n2");

            // Assert
            Assert.AreEqual(3, cal.CalculatedValue);
        }

        [TestMethod]
        public async Task AsyncCalculatorMixDelimeterShort()
        {
            // Act
            await this.cal.Calculator(@"1,2\n3,4,5\n1");

            // Assert
            Assert.AreEqual(16, cal.CalculatedValue);
        }
    }
}
