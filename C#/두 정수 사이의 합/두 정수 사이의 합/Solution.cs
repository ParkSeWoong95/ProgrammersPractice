using System;
using System.Collections.Generic;
using System.Text;

namespace 두_정수_사이의_합
{
    class Solution
    {
        public static long solution(int a, int b) // 프로그래머스 넣을때는 static 빼야함 경로를 못찾음
        {
            long sum = 0;
            if (a == b)
            {
                return a;
            }
            else if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    sum += i;
                }
            }
            else if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    sum += i;
                }
            }
            // Console.WriteLine(sum);
            return sum;
        }
    }
}
