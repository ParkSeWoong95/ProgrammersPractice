using System;
using System.Collections.Generic;

namespace Desc_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            so.solution(8000000000);
        }
    }

    public class Solution
    {
        public long solution(long n)
        {
            /*
            long answer = 0;
            List<int> list = new List<int>();

            while (n != 0)
            {
                long xx = n % 10; 
                list.Add((int)xx);
                n = n / 10;
            }

            list.Sort();
            list.Reverse();

            string x = "";
            for (int i = 0; i < list.Count; i++)
            {
                x += list[i].ToString();
            }

            answer = long.Parse(x);
            Console.WriteLine(answer);
            return answer;
            */

            long answer = 0;
            char[] a = n.ToString().ToCharArray();
            System.Array.Sort(a);
            System.Array.Reverse(a);
            answer = System.Convert.ToInt64(new string(a));
            return answer;
        }
    }
}
