using System;
using System.Linq;
using System.IO;

namespace LeetCodePractice
{
    public class AlgoLeague_TheMistOfBeykozKundura
    {
        static void Main(String[] args)
        {

            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            long[] lost = Array.ConvertAll(("0 " + Console.ReadLine()).Split(), long.Parse);
            int[] x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] y = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            long ans = 0;
            int[] p = new int[n + 1];
            for (int i = 1; i <= n; i++) 
            { 
                p[i] = i; ans += lost[i]; 
            }

            for (int j = 0; j < m; j++)
            {
                int u = x[j], v = y[j];
                while (p[u] != u)
                    u = p[u] = p[p[u]];

                while (p[v] != v)
                    v = p[v] = p[p[v]];

                if (u == v)
                {
                    lost[u] = 0;
                }
                else 
                {
                    p[v] = u; lost[u] = Math.Min(lost[u], lost[v]); 
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (p[i] == i) ans -= lost[i];
            }

            Console.WriteLine(ans);


        }
    }
}

