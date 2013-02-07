using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstDevelopmentDemoxUnit.Test
{
    using TestFirstDevelopmentDemo;

    using Xunit;


    public class Class1
    {
        // Arrange
        private CalculatorCompleted cal;

        public Class1()
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
