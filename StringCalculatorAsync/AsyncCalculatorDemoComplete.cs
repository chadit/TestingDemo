namespace StringCalculatorAsync
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class AsyncCalculatorDemoComplete
    {
        public int CalculatedValue { get; set; }

        public Task Calculator(string s)
        {
            return Task<int>.Run(() =>
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
                CalculatedValue = num;
            });
        }
    }
}