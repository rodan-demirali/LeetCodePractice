using FluentAssertions;
using LeetCodePractice.Easy;
using Xunit;

namespace LeetCodePractice.Tests.Easy;

public class Problem3536_MaximumProductOfTwoDigitsTests
{
    [Theory]
    [InlineData(31, 3)]
    [InlineData(22, 4)]
    public void TestCases(int input, int expected)
    {
        var solution = new Problem3536_MaximumProductOfTwoDigits();

        solution.MaxProduct(input).Should().Be(expected);
    }
}
