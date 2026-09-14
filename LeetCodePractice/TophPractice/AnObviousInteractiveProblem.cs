using System;

namespace LeetCodePractice.TophPractice;

public class AnObviousInteractiveProblem
{
    static void Main(String[] args)
    {
        int left = 0;
        int right = 1000000;

        while(left <= right)
        {
            int mid = left + (right - left) / 2;

            Console.WriteLine(mid);
            Console.Out.Flush();

            string response = Console.ReadLine();

            if(response == "Bingo!")
            {
                return;
            }
            else if(response == "Smaller")
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
    }


}
