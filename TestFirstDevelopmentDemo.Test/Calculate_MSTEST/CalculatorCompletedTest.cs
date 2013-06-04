namespace TestFirstDevelopmentDemo.Test.Calculate_MSTEST
{
    using System;

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
            this.cal = new CalculatorCompleted();
        }

        [TestMethod]
        public void CalculatorEmptyStringTest()
        {
            // Act
            var returnValue = this.cal.Calculator(string.Empty);

            // Assert
            Assert.AreEqual(0, returnValue);
        }

        [TestMethod]
        [TestCategory("Calculator-Comma")]
        public void CalculatorTwoNumberStringTest()
        {
            // Act
            var returnValue = this.cal.Calculator("1,2");

            // Assert
            Assert.AreEqual(3, returnValue);
        }

        [TestMethod]
        [TestCategory("Calculator-Comma")]
        public void CalculatorThreeNumberStringTest()
        {
            // Act
            var returnValue = this.cal.Calculator("1,2,3");

            // Assert
            Assert.AreEqual(6, returnValue);
        }

        [TestMethod]
        [TestCategory("Calculator-NewLine")]
        public void CalculatorNewLineDelimeterTest()
        {
            // Act
            var returnValue = this.cal.Calculator(@"1\n2");

            // Assert
            Assert.AreEqual(3, returnValue);
        }

        [TestMethod]
        public void CalculatorMixDelimeterShort()
        {
            // Act
            var returnValue = this.cal.Calculator(@"1,2\n3,4,5\n1");

            // Assert
            Assert.AreEqual(16, returnValue);
        }

        // Comptact test to help with Dry till Microsoft Gets thier head out thier @!#$ and gives us Row support
        [TestMethod]
        public void CalcualtorEmpty_Test()
        {
            // Arrange
            var valueSent = string.Empty;
            this.CalculatorTest(0, valueSent);
        }

        [TestMethod]
        public void CalcualtorSmallNumber_Test()
        {
            // Arrange
            var valueSent = "1,2";
            this.CalculatorTest(3, valueSent);
        }

        [TestMethod]
        public void CalculatorTest(int originalVlaue, string passedInparm)
        {
            // Act
            var returnValue = this.cal.Calculator(passedInparm);

            // Assert
            Assert.AreEqual(originalVlaue, returnValue);
        }



        #region private Test
        [TestMethod]
        public void CalcualtorPrivateSmallNumber_Test()
        {
            // Arrange
            var valueSent = "1,2";
            CalculatorCompleted calCom = new CalculatorCompleted();
            PrivateObject cal1 = new PrivateObject(calCom);
            var returned = cal1.Invoke("CalculatorPrivate", valueSent);
            Assert.AreEqual(3, returned);


            // this.CalculatorTest(3, valueSent);
        }
        #endregion

        #region Protected Test
        [TestMethod]
        public void CalcualtorProtectedSmallNumber_Test()
        {
            // Arrange
            var valueSent = "1,2";
            CalculatorCompleted calCom = new CalculatorCompleted();
            PrivateObject cal1 = new PrivateObject(calCom);
            var returned = cal1.Invoke("CalculatorPrivate", valueSent);
            Assert.AreEqual(3, returned);


            // this.CalculatorTest(3, valueSent);
        }
        #endregion


    }
}