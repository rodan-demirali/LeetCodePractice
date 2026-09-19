using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.TophPractice;

public class ANewToughGame
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        char[] query = new char[N];

        for (int i = 0; i < N; i++)
        {
            query[i] = 'a';
        }

        Console.WriteLine('?' + new string(query));
        Console.Out.Flush();

        int firstRes = int.Parse(Console.ReadLine());

        char[] ans = new char[N];
        for (int i = 0; i < N; i++)
        {
            query[i] = 'z';

            Console.WriteLine('?' + new string(query));
            Console.Out.Flush();

            int response = int.Parse(Console.ReadLine());

            int difference = response - firstRes;

            int differenceZ = (25 + difference) / 2;

            ans[i] = (char)('z' - differenceZ);

            query[i] = 'a';
        }

        Console.WriteLine('!' + new string(ans));
        Console.Out.Flush();

    }
}
