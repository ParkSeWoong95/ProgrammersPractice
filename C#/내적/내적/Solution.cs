using System;
using System.Collections.Generic;
using System.Text;

namespace 내적
{
    class Solution
    {
        public int solution(int[] a, int[] b)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i] * b[i];
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
