using System;
using System.Collections.Generic;
using System.Text;

namespace 문자열을정수로바꾸기
{
    class Solution
    {
        public int solution(string str)
        {
            int answer = 0;

            answer = Convert.ToInt32(str);
            Console.WriteLine(answer);
            return answer;

        }
    }
}
