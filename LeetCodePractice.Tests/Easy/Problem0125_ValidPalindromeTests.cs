using FluentAssertions;
using LeetCodePractice.Easy;
using Xunit;

namespace LeetCodePractice.Tests.Easy;

public class Problem0125_ValidPalindromeTests
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    [InlineData("0P", false)]
    public void TestCases(string input, bool expected)
    {
        var solution = new Problem0125_ValidPalindrome();

        solution.IsPalindrome(input).Should().Be(expected);
    }
}
