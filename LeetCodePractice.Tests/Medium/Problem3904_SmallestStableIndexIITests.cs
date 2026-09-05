using FluentAssertions;
using LeetCodePractice.Easy;
using LeetCodePractice.Medium;
using Xunit;

namespace LeetCodePractice.Tests;

public class Problem3904_SmallestStableIndexIITests
{
    [Fact]
    public void Example1()
    {
        var solution = new Problem3904_SmallestStableIndexII();

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
        var solution = new Problem3904_SmallestStableIndexII();

        solution.FirstStableIndex(nums, k).Should().Be(expected);
    }
}
