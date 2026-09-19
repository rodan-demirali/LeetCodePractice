using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace LeetCodePractice.CodeForces;

public class AlgoLeague_Waterlogged
{
    public static void Main(string[] args)
    {
        //int n = int.Parse(Console.ReadLine()!);

        //int pos = 0;

        //int dir = 1; 
        //var visited = new HashSet<int>();
        //for (int q = 0; q < 30; q++)
        //{
        //    Console.WriteLine("? " + pos);
        //    Console.Out.Flush();

        //    int val = int.Parse(Console.ReadLine()!);

        //    if (val == -1 || val == 0)
        //    {
        //        return;
        //    }

        //    if (visited.Contains(val))
        //    {
        //        dir = -dir;
        //    }
        //    visited.Add(val);

        //    int target = pos + dir * val;

        //    if (target < 0)
        //    {
        //        target = 0;
        //        dir = 1;
        //    }
        //    else if (target > n)
        //    {
        //        target = n;
        //        dir = -1;
        //    }

        //    pos = target;
        //}


        int T = int.Parse(Console.ReadLine());

        while (T-- > 0)
        {
            string s = Console.ReadLine();

            if (s[0] == '1' || s[s.Length - 1] == '1')
            {
                Console.WriteLine("Boz");
                continue;
            }   

            int previousOne = -1;
            bool enesWins = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '1')
                    continue;

                if (previousOne != -1)
                {
                    if (i - previousOne != 2)
                    {
                        enesWins = true;
                        break;
                    }
                }

                previousOne = i;
            }

            if (enesWins)
            {
                Console.WriteLine("Enes");
            }
            else
            {
                Console.WriteLine("Boz");
            }
        }



    }
}
