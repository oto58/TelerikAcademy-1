﻿namespace InfiniteConvergentSeries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Helper;

    public delegate void ConvergentSeriesDelegate();

    /// <summary>
    /// Problem 20.* Infinite convergent series
    /// By using delegates develop an universal static method to calculate the sum of infinite convergent series with given precision depending on a function of its term. By using proper functions for the term calculate with a 2-digit precision the sum of the infinite series:
    /// 1 + 1/2 + 1/4 + 1/8 + 1/16 + …
    /// 1 + 1/2! + 1/3! + 1/4! + 1/5! + …
    /// 1 + 1/2 - 1/4 + 1/8 - 1/16 + … 
    /// </summary>
    public class ConvergentSeriesCalculator
    {
        public static void Main()
        {
            HelperMethods.DisplayTaskDescription(Constants.PathToTaskDescription);

            // TODO
        }
    }
}
