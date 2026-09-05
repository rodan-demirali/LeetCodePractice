using FluentAssertions;
using LeetCodePractice.Easy;
using Xunit;

namespace LeetCodePractice.Tests.Easy;

public class Problem3903_SmallestStableIndexITests
{
    [Fact]
    public void Example1()
    {
        var solution = new Problem3903_SmallestStableIndexI();

        var result = solution.FirstStableIndex(
            new[] { 5, 0, 1, 4 },
            3
        );

        result.Should().Be(3);
    }


    [Theory]
    [InlineData(new[] { 5, 0, 1, 4 }, 3, 3)]
    [InlineData(new[] { 3, 2, 1 }, 1, -1)]
    [InlineData(new[] { 0 }, 0, 0)]
    public void TestCases(int[] nums, int k, int expected)
    {
        var solution = new Problem3903_SmallestStableIndexI();

        solution.FirstStableIndex(nums, k).Should().Be(expected);
    }
}