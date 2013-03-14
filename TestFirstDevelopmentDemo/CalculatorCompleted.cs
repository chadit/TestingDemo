namespace TestFirstDevelopmentDemo
{
    using System;

    public class CalculatorCompleted
    {
        public int Calculator(string s)
        {
            var num = 0;
            if (s != string.Empty)
            {
                var stringSprilt = s.Split(new[] { ",", "\\n" }, StringSplitOptions.None);
                foreach (var value in stringSprilt)
                {
                    num += int.Parse(value);
                    // Thread.Sleep(1000);
                }
            }

            return num;
        }
    }
}