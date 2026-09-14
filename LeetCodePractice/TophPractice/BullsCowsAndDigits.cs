using System;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace LeetCodePractice.TophPractice;

public class BullsCowsAndDigits
{
    //    Bulls, Cows, and Digits
    //Let's play a game.

    //This game is a few centuries old.Nonetheless, it is a good one for an interactive problem.

    //This is the game of bulls and cows.

    //Cowboy Sherlock will guess a string with 4 digits in it.Each digit will be unique.You will have to guess what that string is.

    //Every time you guess, cowboy Sherlock will tell you the number of bulls and cows he sees.Don't fret, though. This is just Sherlock's way of giving you some hints.

    //The number of bulls implies the number of digits that you have guessed correctly, both in terms of the digits themselves and their positions. The number of cows implies the number of digits that you have guessed correctly, that they are present in the string, but not in the correct positions.

    //Confused? Here is an example:

    //Let's say Sherlock has guessed the string "7482". If you are to guess "4832", Sherlock will say "1 bull, 2 cows". Because, you have guessed that 4 and 8 are present in the string (but you didn't guess their correct positions), hence "2 cows". And, you have guessed that 2 is present in the string (along with its correct position: 4th digit), hence "1 bull".

    //You will get at most 100 chances to guess the correct string for each test case.

    //The game is simple, and cowboy Sherlock's patience is little. So, get coding!
    //Input

    //Every time you print a guess, you will receive two integers as input representing the number of bulls and cows.The numbers will always be between 0 and 4, and their sum will always be less than or equal to 4.
    //Output

    //Print your guess as a string with four digits followed by a newline character.Like so:

    //"0123\n"

    //Do not print anything after you have guessed the correct string (i.e.after you receive “4 0” as input).


    public static int[] GetResults(string guess, string candidate)
    {
        int bulls = 0;
        int cows = 0;

        for (int i = 0; i < 4; i++)
        {
            if (guess[i] == candidate[i])
            {
                bulls++;
            }
            else if (candidate.IndexOf(guess[i]) >= 0)
            {
                cows++;
            }
        }
        return new int[] { bulls, cows };
    }


    static void Main(String[] args)
    {
        List<string> candidates = new List<string>();
        for (int a = 0; a <= 9; a++)
        {
            for (int b = 0; b <= 9; b++)
            {
                for (int c = 0; c <= 9; c++)
                {
                    for (int d = 0; d <= 9; d++)
                    {
                        if (a == b || a == c || a == d || b == c || b == d || c == d) continue;

                        candidates.Add($"{a}{b}{c}{d}");
                    }
                }
            }
        }


        while (true)
        {
            string guess = candidates[0];

            Console.WriteLine(guess);
            Console.Out.Flush();

            string[] response = Console.ReadLine().Split();

            int bulls = int.Parse(response[0]);
            int cows = int.Parse(response[1]);

            if(bulls == 4 && cows == 0)
            {
                return;
            }

            List<string> newCandidates = new List<string>();

            foreach (var candidate in candidates)
            {
                int[] result = GetResults(guess, candidate);

                if (result[0] == bulls && result[1] == cows)
                {
                    newCandidates.Add(candidate);
                }
            }

            candidates = newCandidates;
        }
    }



}
