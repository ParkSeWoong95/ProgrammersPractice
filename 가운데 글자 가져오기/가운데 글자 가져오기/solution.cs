using System;
using System.Collections.Generic;
using System.Text;

namespace 가운데_글자_가져오기
{
    class Solution
    {
        public static string stringSolution(string s)
        {
            string answer = "";
            if (s.Length % 2 == 0)
            {
                answer = s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();
            }
            else
            {
                answer = s[s.Length / 2].ToString();
            }
            return answer;
        }
    }
}
