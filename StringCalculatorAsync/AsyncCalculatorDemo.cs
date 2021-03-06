﻿namespace StringCalculatorAsync
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class AsyncCalculatorDemo
    {
        public int CalculatedValue { get; set; }

        public Task Calculator(string s)
        {
            return Task<int>.Run(() =>
            {
                CalculatedValue = -20;
            });
        }
    }
}
