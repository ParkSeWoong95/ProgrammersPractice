using System;
using System.Collections.Generic;
using System.Text;

namespace 평균구하기
{
    class EvaluateMean
    {
        public static double solution(int[] arr)
        {
            double mean = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                mean = (double)sum / arr.Length;

            }
            Console.WriteLine(mean);
            return mean;
        }
    }
}
