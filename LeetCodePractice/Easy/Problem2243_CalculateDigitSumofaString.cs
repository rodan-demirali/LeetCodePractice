using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Easy
{
    public class Problem2243_CalculateDigitSumofaString
    {
        public static string DigitSum(string s, int k)
        {

            while(s.Length > k)
            {
                string newS = "";

                int i = 0;
                while(i < s.Length)
                {
                    string part = s.Substring(i, Math.Min(k, s.Length - i));

                    int sum = 0;
                    foreach(char c in part)
                    {
                        sum += c - '0';
                    }
                    newS += sum.ToString();

                    i += k;
                }

                s = newS;
            }


            return s;


        }
    }
}
