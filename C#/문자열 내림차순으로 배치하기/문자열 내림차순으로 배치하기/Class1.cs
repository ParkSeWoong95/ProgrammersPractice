using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace 문자열_내림차순으로_배치하기
{
    class Class1
    {
        public static string solution(string s)
        {
            string answer = "";
            char[] array = s.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        char temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                answer += array[i];
            }
            return answer;
        }
    }
}
