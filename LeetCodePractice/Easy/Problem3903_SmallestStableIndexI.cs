namespace LeetCodePractice.Easy;

public class Problem3903_SmallestStableIndexI
{
    public int FirstStableIndex(int[] nums, int k)
    {
        int iLen = nums.Length;

        int[] prefixMax = new int[iLen];
        int[] suffixMin = new int[iLen];

        prefixMax[0] = nums[0];

        for (int i = 1; i < iLen; i++)
        {
            if (prefixMax[i - 1] < nums[i])
            {
                prefixMax[i] = nums[i];
            }
            else
            {
                prefixMax[i] = prefixMax[i - 1];
            }
        }

        suffixMin[iLen - 1] = nums[iLen - 1];

        for (int i = iLen - 2; i >= 0; i--)
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

        for(int i = 0; i < iLen; i++)
        {
            int score = prefixMax[i] - suffixMin[i];

            if(score <= k)
            {
                return i;
            }
        }

        return -1;

    }
}
