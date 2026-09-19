using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.CodeForces;

public class _1546B_AquaMoonAndStolenString
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        while(t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[] xor = new int[m];

            for (int i = 0; i < n; i++) //read originals
            {
                string s = Console.ReadLine();

                for (int j = 0; j < m; j++) //each same index character xor
                {
                    xor[j] ^= s[j];
                }
            }

            for (int i = 0; i < n - 1; i++) //read remainings
            {
                string s = Console.ReadLine();

                for (int j = 0; j < m; j++) //each same index character xor
                {
                    xor[j] ^= s[j];
                }
            }

            StringBuilder ans = new StringBuilder();

            for (int i = 0; i < m; i++) //append each index remaining xor'ed to answer sttring
            {
                ans.Append((char)(xor[i]));
            }

            Console.WriteLine(ans.ToString());
            Console.Out.Flush();


        }
    }
}
