using System;
using System.Collections.Generic;
using System.Text;

namespace Greatest_common_multiple_factor
{
    class Greatest_common
    {
        public static int[] solution(int n, int m)
        {
            int[] answer = new int[2];

            int maxNum;
            int minNum;
            if (n > m)
            {
                maxNum = n;
                minNum = m;
            }
            else
            {
                maxNum = m;
                minNum = n;
            }
            answer[0] = GCD(maxNum, minNum);
            answer[1] = maxNum * minNum / answer[0];
            return answer;
        }
        public static int GCD(int maxNum, int minNum)
        {
            if (maxNum % minNum == 0)
            {
                return minNum;
            }
            else
            {
                return GCD(minNum, maxNum % minNum);
            }
        }
    }
}
