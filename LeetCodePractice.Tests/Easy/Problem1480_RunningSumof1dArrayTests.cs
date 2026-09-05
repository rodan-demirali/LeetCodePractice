using FluentAssertions;
using LeetCodePractice.Easy;
using Xunit;

namespace LeetCodePractice.Tests;

public class Problem1480_RunningSumof1dArrayTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 })]
    public void TestCases(int[] input, int[] expected)
    {
        var solution = new Problem1480_RunningSumof1dArray();

        solution.RunningSum(input).Should().Equal(expected);
    }
}
