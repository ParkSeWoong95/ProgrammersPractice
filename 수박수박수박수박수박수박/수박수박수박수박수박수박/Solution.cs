using System;
using System.Collections.Generic;
using System.Text;

namespace 수박수박수박수박수박수박
{
    class Solution
    {
        public static string solution(int n)
        {
            string first = "수";
            string second = "박";
            string answer = "";

            for (int i = 1; i <= n; i++)
            {
                if( i % 2 != 0)
                {
                    answer += first;
                }
                else
                {
                    answer += second;
                }
            }
            return answer;
        }
    }
}
