using FluentAssertions;
using LeetCodePractice.Easy;
using Xunit;

namespace LeetCodePractice.Tests.Easy;

public class Problem0001_TwoSumTests
{
    [Fact]
    public void Example1()
    {
        var solution = new Problem0001_TwoSum();

        var result = solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);

        result.Should().BeEquivalentTo(new[] { 0, 1 });
    }

    [Fact]
    public void Example2()
    {
        var solution = new Problem0001_TwoSum();

        var result = solution.TwoSum(new[] { 3, 2, 4 }, 6);

        result.Should().BeEquivalentTo(new[] { 1, 2 });
    }

    [Fact]
    public void Example3()
    {
        var solution = new Problem0001_TwoSum();

        var result = solution.TwoSum(new[] { 3, 3 }, 6);

        result.Should().BeEquivalentTo(new[] { 0, 1 });
    }
}
