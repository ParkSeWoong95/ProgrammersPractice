using System;
using System.Collections.Generic;
using System.Text;

namespace 핸드폰_번호_가리기
{
    class Solution
    {
        public static string solution(string phone_number)
        {
            string answer = "";
            // char[] x = phone_number.ToCharArray();

            for (int i = 0; i < phone_number.Length; i++)
            {
                if (i < phone_number.Length - 4)
                {
                    answer += '*';
                }
                else
                {
                    answer += phone_number[i];
                }
            }
            return answer;
        }
    }
}
