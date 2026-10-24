using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Easy
{
    public class Problem2409_CountDaysSpentTogether
    {
        public static int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
        {
            // StringBuilder sbm1 = new StringBuilder(arriveAlice);

            //int monthaa = int.Parse(arriveAlice.Substring(0, 2)); //
            //int dayaa = int.Parse(arriveAlice.Substring(3, 2)); //15
            //int monthla = int.Parse(leaveAlice.Substring(0, 2)); //08
            //int dayla = int.Parse(leaveAlice.Substring(3, 2)); //18


            //int monthab = int.Parse(arriveBob.Substring(0, 2)); //08
            //int dayab = int.Parse(arriveBob.Substring(3, 2)); //16
            //int monthlb = int.Parse(leaveBob.Substring(0, 2)); //08
            //int daylb = int.Parse(leaveBob.Substring(3, 2)); //19

            //if ((monthab == monthla && dayab > dayla) || (monthab > monthla) ) return 0;

            //int together = dayla - dayab + 1;

            int[] daysinmonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] daysinmonthsum = new int[] {0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334, 365};

            int monthaa = int.Parse(arriveAlice.Substring(0, 2)); //
            int dayaa = int.Parse(arriveAlice.Substring(3, 2)); //15
            int monthla = int.Parse(leaveAlice.Substring(0, 2)); //08
            int dayla = int.Parse(leaveAlice.Substring(3, 2)); //18

            int monthab = int.Parse(arriveBob.Substring(0, 2)); //08
            int dayab = int.Parse(arriveBob.Substring(3, 2)); //16
            int monthlb = int.Parse(leaveBob.Substring(0, 2)); //08
            int daylb = int.Parse(leaveBob.Substring(3, 2)); //19

            int a1 = daysinmonthsum[monthaa - 1] + dayaa;
            int a2 = daysinmonthsum[monthla - 1] + dayla;
            int b1 = daysinmonthsum[monthab - 1] + dayab;
            int b2 = daysinmonthsum[monthlb - 1] + daylb;

            int start = Math.Max(a1, b1);
            int end = Math.Min(a2, b2);
            int together = Math.Max(0, end - start + 1);


            return together;

        }
    }
}

