using System;
using System.Collections.Generic;
using System.Linq;

namespace H01.TypeExtensions.Core.Extensions
{
    public static class ListIntExtensions
    {
        public static double SquareMeanRoot(this List<int> numbers)
        {
            double sum = numbers.Sum(n => n * n);
            return Math.Sqrt(sum / numbers.Count);
        }
    }
}
