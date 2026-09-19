using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.CodeForces
{
    public class _1807E__Interview
    {
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while(t-- > 0)
            {
                int n = int.Parse(Console.ReadLine()); //5
                string[] input = Console.ReadLine().Split(); // { 1, 2, 3, 4, 5 }

                long[] a = new long[n + 1];

                for (int i = 1; i <= n; i++)
                {
                    a[i] = long.Parse(input[i - 1]);
                }

                int left = 1;
                int right = n;

                while( left < right)
                {
                    int mid = (left + right) / 2;
                    long normalSum = 0;
                    Console.Write("? " + (mid - left + 1));

                    for (int i = left; i <= mid; i++)
                    {
                        Console.Write(" " + i);
                        normalSum += a[i];
                    }

                    Console.WriteLine();
                    Console.Out.Flush();

                    long realSum = long.Parse(Console.ReadLine());

                    if(realSum > normalSum)
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }

                }
                Console.WriteLine("! " + left);
                Console.Out.Flush();
            }
        }
    }
}
