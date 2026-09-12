using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Hard
{
    public class Problem3414_MaximumScoreOfNonOverlappingIntervals
    {
        public int[] MaximumWeight(List<List<int>> intervals)
        {
            int n = intervals.Count;

            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[]
                {
                    intervals[i][0],
                    intervals[i][1],
                    intervals[i][2],
                    i
                };
            }


            Array.Sort(arr, (a, b) =>
            {
                if (a[0] != b[0])
                {
                    return a[0].CompareTo(b[0]);
                }

                return a[1].CompareTo(b[1]);
            });

            int[] starts = new int[n];
            for(int i = 0; i < n; i++)
            {
                starts[i] = arr[i][0];
            }

            int[] next = new int[n];
            for (int i = 0; i < n; i++)
            {
                next[i] = FindNextInterval(starts, arr[i][1]);
            }

            List<int>[,] dp = new List<int>[n + 1, 5];

            for (int i = 0; i <= n; i++)
            {
                dp[i, 0] = new List<int>();
            }

            for (int k = 1; k <= 4; k++)
            {
                dp[n, k] = new List<int>();
            } 

            for (int i = n - 1; i >= 0; i--)
            {
                for (int k = 1; k <= 4; k++)
                {
                    List<int> skip = dp[i + 1, k];

                    List<int> take = new List<int>();
                    take.Add(arr[i][3]);

                    if (k > 1)
                    {
                        take.AddRange(dp[next[i], k - 1]);
                    }

                    long skipScore = GetScore(skip, intervals);
                    long takeScore = arr[i][2] + GetScore(dp[next[i], k - 1], intervals);

                    if (takeScore > skipScore)
                    {
                        dp[i, k] = take;
                    }
                    else if (takeScore < skipScore)
                    {
                        dp[i, k] = new List<int>(skip);
                    }
                    else
                    {
                        dp[i, k] = LexicographicallySmaller(take, skip);
                    }
                }
            }

            dp[0, 4].Sort();

            return dp[0, 4].ToArray();
        }

        private int FindNextInterval(int[] starts, int end)
        {
            int left = 0;
            int right = starts.Length;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if(starts[mid] <= end)
                {
                    left = mid  + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }

        private long GetScore(List<int> indices, List<List<int>> intervals)
        {
            long score = 0;

            foreach (int index in indices)
            {
                score += intervals[index][2];
            }

            return score;
        }

        private List<int> LexicographicallySmaller(List<int> first, List<int> second)
        {
            List<int> a = new List<int>(first);
            List<int> b = new List<int>(second);

            a.Sort();
            b.Sort();

            int length = Math.Min(a.Count, b.Count);

            for (int i = 0; i < length; i++)
            {
                if (a[i] < b[i])
                    return first;

                if (a[i] > b[i])
                    return second;
            }

            if (a.Count <= b.Count)
                return first;

            return second;
        }
    }
}
