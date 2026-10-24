using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Medium;

public class Problem3727_MaximumAlternatingSumOfSquares
{
    public static long MaxAlternatingSum(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            nums[i] *= nums[i];
        }

        nums = nums.OrderByDescending(x => x).ToArray();

        int sum = 0;
        int mid = (n + 1) / 2;
        for (int i = 0; i < mid; i++)
        {
            sum += nums[i];
        }

        for (int i = mid; i < n; i++)
        {
            sum -= nums[i];
        }

        return sum;

    }
}
