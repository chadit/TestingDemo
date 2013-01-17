namespace TestFirstDevelopmentDemo
{
    using System;

    public class CalculatorCompleted
    {
        public int Calculator(string s)
        {
            try
            {
                var num = 0;
                if (s != string.Empty)
                {
                    var stringSprilt = s.Split(new[] { ",", "\\n" }, StringSplitOptions.None);
                    foreach (var value in stringSprilt)
                    {
                        num += int.Parse(value);
                    }
                }

                return num;
            }
            catch (Exception)
            {
                return -99999999;
            }
        }
    }
}