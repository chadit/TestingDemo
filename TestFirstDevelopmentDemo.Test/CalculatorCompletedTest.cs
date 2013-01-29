namespace TestFirstDevelopmentDemo.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TestFirstDevelopmentDemo;

    [TestClass]
    public class CalculatorCompletedTest
    {
        // Arrange
        private CalculatorCompleted cal;

        [TestInitialize]
        public void Setup()
        {
            cal = new CalculatorCompleted();
        }

        [TestMethod]
        public void CalculatorTestEmptyString()
        {
            // Act
            var returnValue = cal.Calculator(string.Empty);

            // Assert
            Assert.AreEqual(0, returnValue);
        }

        [TestMethod]
        public void CalculatorTestTwoNumberString()
        {
            // Act
            var returnValue = cal.Calculator("1,2");

            // Assert
            Assert.AreEqual(3, returnValue);
        }

        [TestMethod]
        public void CalculatorTestThreeNumberString()
        {
            // Act
            var returnValue = cal.Calculator("1,2,3");

            // Assert
            Assert.AreEqual(6, returnValue);
        }

        [TestMethod]
        public void CalculatorTestNewLineDelimeter()
        {
            // Act
            var returnValue = cal.Calculator(@"1\n2");

            // Assert
            Assert.AreEqual(3, returnValue);
        }

        [TestMethod]
        public void CalculatorTestMixDelimeterShort()
        {
            // Act
            var returnValue = cal.Calculator(@"1,2\n3,4,5\n1");

            // Assert
            Assert.AreEqual(16, returnValue);
        }

        // Comptact test to help with Dry till Microsoft Gets thier head out thier @!#$ and gives us Row support
        [TestMethod]
        public void CalcualtorEmpty_Test()
        {
            // Arrange
            var valueSent = string.Empty;
            CalculatorTest(0, valueSent);
        }

        [TestMethod]
        public void CalcualtorSmallNumber_Test()
        {
            // Arrange
            var valueSent = "1,2";
            CalculatorTest(3, valueSent);
        }

        [TestMethod]
        public void CalculatorTest(int originalVlaue, string passedInparm)
        {
            // Act
            var returnValue = cal.Calculator(passedInparm);

            // Assert
            Assert.AreEqual(originalVlaue, returnValue);
        }

        // If we had nunit installed or microsoft pushes row support
        /*  [TestMethod]
          [Row(0, string.Empty)]
          [Row(3, "1,2")]
          [Row(6, "1,2,3")]
          [Row(3, @"1\n2")]
          public void CalculatorTestWithRowSupport(int originalVlaue, string passedInparm)
          {
              // Act
              var returnValue = cal.Calculator(passedInparm);

              // Assert
              Assert.AreEqual(originalVlaue, returnValue);
          }
         */
    }
}