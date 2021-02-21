using System;
using System.Collections.Generic;
using System.Text;

namespace 서울에서_김서방_찾기
{
    class Find_Kim
    {
        public static string solution(string[] seoul)
        {
            string answer = "";
            
            for( int i = 0; i < seoul.Length; i++)
            {
                if ( seoul[i] == "Kim")
                {
                    answer = ("김서방은 " +i +"에 있다");
                }
            }

            return answer;
        }
    }
}
