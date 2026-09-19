using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.CodeForces
{
    public class AlgoLeague_TailorZeynep
    {
        static string Solve(string s)
        {
            int n = s.Length;

            if (s[0] == '1' || s[n - 1] == '1')
                return "Boz";

            int first = s.IndexOf('1');
            if (first == -1) return "Boz";

            int last = s.LastIndexOf('1');

            for (int i = first; i < last; i++)
            {
                if (s[i] == s[i + 1])
                {
                    return "Enes";
                }
            }

            return "Boz";
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            //var sb = new StringBuilder();
            while (t-- > 0)
            {
                string s = Console.ReadLine();
                //sb.AppendLine(s);

                int n = s.Length;

                if (s[0] == '1' || s[n - 1] == '1')
                {
                    Console.WriteLine("Boz");
                }
                else
                {
                    int first = s.IndexOf('1');
                    if (first == -1)
                    {
                        Console.WriteLine("Boz");
                    }
                    else
                    {
                        int last = s.LastIndexOf('1');
                        bool found = false;
                        for (int i = first; i < last; i++)
                        {
                            if (s[i] == s[i + 1])
                            {
                                Console.WriteLine("Enes");
                                found = true;
                                break;
                            }
                        }
                        if (found == false)
                        {
                            Console.WriteLine("Boz");
                        }
                    }
                }
            }
        }
    }
}

