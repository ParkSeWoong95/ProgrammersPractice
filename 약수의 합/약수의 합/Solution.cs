using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace 약수의_합
{
    class Solution
    {
        public static int solution(int n)
        {
            int answer = 0;
            for( int i =1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    answer += i;
                }
            }
            return answer;
        }
    }
}
