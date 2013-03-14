using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
