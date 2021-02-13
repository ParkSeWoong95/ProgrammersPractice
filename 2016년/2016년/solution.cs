using System;


namespace _2016년
{
    class Solution
    {
        public static string solution(int a, int b)
        {
            string m = "Monday";
            string t = "Tuesday";
            string w = "Wednesday";
            string th = "Thursday";
            string f = "Friday";
            string s = "Saturday";
            string sun = "Sunday";

            var date1 = new DateTime(2016, a, b);
            string x = date1.DayOfWeek.ToString();
           
            if (x == m)
            {
                return "MON";
            }
            else if (x == t)
            {
                return "TUE";
            }
            else if (x == w)
            {
                return "WED";
            }
            else if (x == th)
            {
                return "THU";
            }
            else if (x == f)
            {
                return "FRI";
            }
            else if (x == s)
            {
                return "SAT";
            }
            else if (x == sun)
            {
                return "SUN";
            }
            return null;
        }
    }
}
