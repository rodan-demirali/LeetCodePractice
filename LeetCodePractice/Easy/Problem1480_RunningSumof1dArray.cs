using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Easy
{
    public class Problem1480_RunningSumof1dArray
    {
        public int[] RunningSum(int[] nums)
        {
            int[] res = new int[nums.Length];

            res[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                res[i] = res[i - 1] + nums[i];
            }

            return res;

        }
    }
}
