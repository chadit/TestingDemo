using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestAsyncDemo
{
    public class AsyncExamples
    {
        public string TestProperty { get; set; }
        public Task SomeLongRunningSleep()
        {
            return Task<string>.Run(() =>
            {
                Thread.Sleep(3000);
                TestProperty = "Hello World";
            });
        }

        // Example from TechEd Europe -- Peter Provost
        // test using Shims
        public void CheckIfEndOfWorld()
        {
            if (DateTime.Now == new DateTime(2000, 1, 1))
            {
                throw new Y2KException();
            }
        }

        // Example from TechEd Europe -- Peter Provost
        // test using Shims
        private void CheckIfEndOfWorldPrivateMethod()
        {
            if (DateTime.Now == new DateTime(2000, 1, 1))
            {
                throw new Y2KException();
            }
        }

        // Example from TechEd Europe -- Peter Provost
        // test using Shims
        protected void CheckIfEndOfWorldProtectedMethod()
        {
            if (DateTime.Now == new DateTime(2000, 1, 1))
            {
                throw new Y2KException();
            }
        }
    }

    public class Y2KException : Exception
    {

    }
}
