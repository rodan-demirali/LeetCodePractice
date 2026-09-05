using LeetCodePractice.Easy;
using LeetCodePractice.Medium;

Console.WriteLine("LeetCode Practice");
Console.WriteLine("-----------------");

// Uncomment a problem while developing it.
//
var solution = new Problem3904_SmallestStableIndexII();
var result = solution.FirstStableIndex(new[] { 5, 0, 1, 4 }, 3);
Console.WriteLine(string.Join(", ", result));
