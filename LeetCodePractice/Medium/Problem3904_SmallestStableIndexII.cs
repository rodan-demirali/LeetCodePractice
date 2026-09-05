using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Medium;

public class Problem3904_SmallestStableIndexII
{
    public int FirstStableIndex(int[] nums, int k)
    {   
        int iLen = nums.Length;

        //int[] prefixMax = new int[iLen];
        int[] suffixMin = new int[iLen];

        suffixMin[iLen - 1] = nums[iLen - 1];
        for(int i = iLen - 2; i >= 0; i--)
        {
            if (suffixMin[i + 1] > nums[i])
            {
                suffixMin[i] = nums[i]; 
            }
            else
            {
                suffixMin[i] = suffixMin[i + 1];
            }
        }

        int iMax = 0;
        for(int i = 0; i < iLen; i++)
        {
            iMax = Math.Max(iMax, nums[i]);
            int score = iMax - suffixMin[i];
            if (score <= k) return i;
        }

        return -1;
    }
}
