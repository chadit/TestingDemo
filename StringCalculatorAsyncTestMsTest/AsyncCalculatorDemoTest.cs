namespace StringCalculatorAsyncTestMsTest
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StringCalculatorAsync;

    [TestClass]
    public class AsyncCalculatorDemoTest
    {
        // Arrange
        private AsyncCalculatorDemo cal;

        [TestInitialize]
        public void Setup()
        {
            this.cal = new AsyncCalculatorDemo();
        }
    }
}
