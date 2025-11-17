using System;
using Xunit;
using Statistics;
using System.Collections.Generic;
namespace Statistics.Tests;

public class StatsUnitTest
{
    [Fact]
    public void ReportsAverageMinMax()
    {
        var statsComputer = new StatsComputer();
        var computedStats = statsComputer.CalculateStatistics(
            new List<float>{98.6F, 98.2F, 97.8F, 102.2F});
        float epsilon = 0.001F;
        Assert.True(Math.Abs(computedStats.Average - 99.2) <= epsilon);
        Assert.True(Math.Abs(computedStats.Max - 102.2) <= epsilon);
        Assert.True(Math.Abs(computedStats.Min - 97.8) <= epsilon);
    }
    [Fact]
    public void ReportsNaNForEmptyInput()
    {
        var statsComputer = new StatsComputer();
        var computedStats = statsComputer.CalculateStatistics(
            new List<float> { });
        float epsilon = 0.001F;
        Assert.True(double.IsNaN(computedStats.Average));
        Assert.True(double.IsNaN(computedStats.Max));
        Assert.True(double.IsNaN(computedStats.Min));
    }
}
