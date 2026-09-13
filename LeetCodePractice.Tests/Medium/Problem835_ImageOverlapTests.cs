using FluentAssertions;
using LeetCodePractice.Medium;
using Xunit;

namespace LeetCodePractice.Tests;

public class Problem835_ImageOverlapTests
{
    [Fact]
    public void Example1_ShouldReturnThree()
    {
        int[][] img1 =
        {
            new[] { 1, 1, 0 },
            new[] { 0, 1, 0 },
            new[] { 0, 1, 0 }
        };

        int[][] img2 =
        {
            new[] { 0, 0, 0 },
            new[] { 0, 1, 1 },
            new[] { 0, 0, 1 }
        };

        var solution = new Problem835_ImageOverlap();

        var result = solution.LargestOverlap(img1, img2);

        result.Should().Be(3);
    }

    [Fact]
    public void Example2_OneByOneImages_ShouldReturnOne()
    {
        int[][] img1 =
        {
            new[] { 1 }
        };

        int[][] img2 =
        {
            new[] { 1 }
        };

        var solution = new Problem835_ImageOverlap();

        var result = solution.LargestOverlap(img1, img2);

        result.Should().Be(1);
    }

    [Fact]
    public void Example3_OneByOneZeroImages_ShouldReturnZero()
    {
        int[][] img1 =
        {
            new[] { 0 }
        };

        int[][] img2 =
        {
            new[] { 0 }
        };

        var solution = new Problem835_ImageOverlap();

        var result = solution.LargestOverlap(img1, img2);

        result.Should().Be(0);
    }

    [Fact]
    public void IdenticalImages_ShouldReturnNumberOfOnes()
    {
        int[][] img1 =
        {
            new[] { 1, 0, 1 },
            new[] { 0, 1, 0 },
            new[] { 1, 0, 1 }
        };

        int[][] img2 =
        {
            new[] { 1, 0, 1 },
            new[] { 0, 1, 0 },
            new[] { 1, 0, 1 }
        };

        var solution = new Problem835_ImageOverlap();

        var result = solution.LargestOverlap(img1, img2);

        result.Should().Be(5);
    }


    [Fact]
    public void AllOnesImages_ShouldReturnNByN()
    {
        int[][] img1 =
        {
            new[] { 1, 1 },
            new[] { 1, 1 }
        };

        int[][] img2 =
        {
            new[] { 1, 1 },
            new[] { 1, 1 }
        };

        var solution = new Problem835_ImageOverlap();

        var result = solution.LargestOverlap(img1, img2);

        result.Should().Be(4);
    }

    [Fact]
    public void Translation_ShouldFindBetterOverlapThanOriginalPosition()
    {
        int[][] img1 =
        {
            new[] { 1, 0, 0 },
            new[] { 1, 0, 0 },
            new[] { 0, 0, 0 }
        };

        int[][] img2 =
        {
            new[] { 0, 1, 0 },
            new[] { 0, 1, 0 },
            new[] { 0, 0, 0 }
        };

        var solution = new Problem835_ImageOverlap();

        var result = solution.LargestOverlap(img1, img2);

        result.Should().Be(2);
    }

    [Fact]
    public void SingleOne_ShouldReturnOneWhenBothImagesContainOne()
    {
        int[][] img1 =
        {
            new[] { 0, 0, 0 },
            new[] { 0, 1, 0 },
            new[] { 0, 0, 0 }
        };

        int[][] img2 =
        {
            new[] { 0, 0, 1 },
            new[] { 0, 0, 0 },
            new[] { 0, 0, 0 }
        };

        var solution = new Problem835_ImageOverlap();

        var result = solution.LargestOverlap(img1, img2);

        result.Should().Be(1);
    }
}
