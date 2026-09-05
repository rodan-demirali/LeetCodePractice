namespace LeetCodePractice.Easy;

public class Problem0001_TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        // TODO: Solve the problem yourself.
        //throw new NotImplementedException();

        Dictionary<int, int> dct = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i];
            if (!dct.ContainsKey(needed))
            {
                dct[nums[i]] = i;
            }
            else
            {
                return new int[] { i, dct[needed] };
            }
        }

        return new int[0];

        //for (int i = 0; i < nums.Length - 1; i++)
        //{
        //    for (int j = i + 1; j < nums.Length; j++)
        //    {
        //        if (nums[i] + nums[j] == target)
        //        {
        //            return new int[] {i, j};
        //        }
        //    }
        //}

        //return new int[0];
    }
}
