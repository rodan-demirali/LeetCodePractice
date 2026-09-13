using FluentAssertions;
using LeetCodePractice.Easy;
using LeetCodePractice.Hard;
using Xunit;

namespace LeetCodePractice.Tests;

public class Problem3414_MaximumScoreOfNonOverlappingIntervalsTests
{
    [Fact]
    public void Example1_ShouldReturnCorrectIndices()
    {
        List<List<int>> intervals = new List<List<int>>
        {
            new List<int> { 1, 3, 2 },
            new List<int> { 4, 5, 2 },
            new List<int> { 1, 5, 5 },
            new List<int> { 6, 9, 3 },
            new List<int> { 6, 7, 1 },
            new List<int> { 8, 9, 1 }
        }; 

        var solution = new Problem3414_MaximumScoreOfNonOverlappingIntervals();

        var result = solution.MaximumWeight(intervals);

        result.Should().Equal(2, 3);
    }



    [Fact]
    public void OneInterval_ShouldReturnItsIndex()
    {
        List<List<int>> intervals = new List<List<int>>
        {
            new List<int> { 1, 5, 10 }
        };

        var solution = new Problem3414_MaximumScoreOfNonOverlappingIntervals();

        var result = solution.MaximumWeight(intervals);

        result.Should().Equal(0);
    }


}