using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            Stats result = new Stats();
            if (numbers.Count == 0)
            {
                result.Min = float.NaN;
                result.Max = float.NaN;
                result.Average = float.NaN;
            }
            else
            {
                result.Min = numbers.Min();
                result.Max = numbers.Max();
                result.Average = numbers.Average();
            }
            return result;
        }
    }
}
