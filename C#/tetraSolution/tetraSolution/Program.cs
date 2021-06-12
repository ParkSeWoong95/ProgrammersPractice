using System;
using System.Collections.Generic;

namespace tetraSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            TetraSolution.Solution(45);
        }
    }


    class TetraSolution
    {
        public static int Solution(int n)
        {
            int answer = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (i / 3 == 0)
                {
                    n = n / 3;
                    list.Add(n);
                    break;
                }
            }
            Console.WriteLine(answer);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            return answer;

        }
    }
}
