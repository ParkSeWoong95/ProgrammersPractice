using System;
using System.Collections.Generic;
using System.Linq;

namespace 소수만들기
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber pn = new PrimeNumber();
            //pn.solution(new int[] { 1, 2, 3, 4 });
            int x = pn.solution(new int[] { 1, 2, 7, 6, 4 });
            Console.WriteLine(x);
        }
    }


    class PrimeNumber
    {
        public int solution(int[] nums)
        {
            int count = 0;
            int sum;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    for (int k = j+1; k < nums.Length; k++)
                    {
                        sum = nums[i] + nums[j] + nums[k];
                        if (PrimeCount(sum))
                        {
                            count++;  
                        }
                    }
                }
            }
            return count;
        }

        // 소수를 체크하는 메서드 작성
        public bool PrimeCount(int sum)
        {
            for (int i = 2; i < sum; i++)
            {
                if(sum % i == 0)
                {
                    return false;;
                }
            }
                return true;
        }
    }
}
