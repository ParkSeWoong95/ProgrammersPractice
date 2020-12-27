using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace 문자열_다루기_기본
{
    class Solution
    {
        public static bool StringArrayCheck(string s)
        {
            bool answer = false;
            char[] split = s.ToCharArray();
            if (!(s.Length == 4 || s.Length == 6))
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (split[i] >= '0' && split[i] <= '9')
                {
                    answer = true;
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine(answer);
            return answer;

        }
    }
}

