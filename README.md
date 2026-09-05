# LeetCodePractice

A simple C# + xUnit project for solving LeetCode problems locally in Visual Studio.

## Requirements

- .NET 8 SDK
- Visual Studio 2022/2026 with .NET desktop development workload

## Run

Open `LeetCodePractice.sln`.

### Run the program

Use the `LeetCodePractice` project when you want to manually debug a solution from `Program.cs`.

### Run tests

Open **Test Explorer** in Visual Studio and run all tests.

You can also use:

```bash
dotnet test
```

## Workflow

1. Create a solution class in `Easy`, `Medium`, or `Hard`.
2. Keep the method signature identical to LeetCode.
3. Add a corresponding xUnit test class.
4. Add official examples plus your own edge cases.
5. Debug locally.
6. Submit only the solution class to LeetCode.

## Naming convention

`Problem<ID>_<ShortName>.cs`

Examples:

- `Problem0001_TwoSum.cs`
- `Problem0015_ThreeSum.cs`
- `Problem0125_ValidPalindrome.cs`

Tests use the same name with `Tests` appended.

## Useful test patterns

For a normal test:

```csharp
[Fact]
public void Example1()
{
    var solution = new Problem0001_TwoSum();

    var result = solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);

    result.Should().BeEquivalentTo(
        new[] { 0, 1 },
        options => options.WithStrictOrdering());
}
```

For many simple input/output combinations:

```csharp
[Theory]
[InlineData("race a car", false)]
[InlineData(" ", true)]
public void TestCases(string input, bool expected)
{
    var solution = new Problem0125_ValidPalindrome();

    solution.IsPalindrome(input).Should().Be(expected);
}
```
