namespace TestFirstDevelopmentDemo
{
    using System;
    using System.Globalization;

    public class Program
    {
        // private static readonly CalculatorBuild CalA = new CalculatorBuild();
        private static readonly CalculatorCompleted CalB = new CalculatorCompleted();

        public static void Main(string[] args)
        {
            Console.WriteLine("The sum of 1,2,3,4,5 should be 15, it is {0}", CalB.Calculator(@"1,2,3,4,5").ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}




























































// Console.WriteLine("The sum of 1,2\\n3,4,5\\n1 should be 16, it is {0}", CalB.Calculator(@"1,2\n3,4,5\n1").ToString(CultureInfo.InvariantCulture));