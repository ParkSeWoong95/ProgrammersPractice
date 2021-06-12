using System;

namespace 소수찾기
{
    class PrimeNumber
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n; i++)
            {
                if (isPrimeNum(i))
                {
                    answer++;
                }
            }
            return answer;
        }

        public static bool isPrimeNum(int number)
        {
            if (number == 1)
            {
                return false;
            }
            int rNum = (int)Math.Sqrt(number);
            for (int i = 2; i <= rNum; i ++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
