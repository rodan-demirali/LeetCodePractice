using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Medium
{
    public class Problem835_ImageOverlap
    {
        public int LargestOverlap(int[][] img1, int[][] img2)
        {
            Dictionary<(int, int), int> dct = new Dictionary<(int, int), int>();

            int maxOverlap = 0;

            for (int row1 = 0; row1 < img1.Length; row1++)
            {
                for (int col1 = 0; col1 < img1.Length; col1++)
                {
                    if (img1[row1][col1] == 0) continue;



                    for (int row2 = 0; row2 < img2.Length; row2++)
                    {
                        for (int col2 = 0; col2 < img2.Length; col2++)
                        {
                            if (img2[row2][col2] == 0) continue;

                            var shift = (row1 - row2, col1 - col2);
                            //dct[shift] = dct.GetValueOrDefault(shift, 0) + 1;
                            if(!dct.ContainsKey(shift))
                                dct[shift] = 0;
                            dct[shift]++;

                            maxOverlap = Math.Max(maxOverlap, dct[shift]);
                        }
                    }
                }
            }

            return maxOverlap;
        }
    }
}
