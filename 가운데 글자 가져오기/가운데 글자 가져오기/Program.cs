using System;

namespace 가운데_글자_가져오기
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcde";
            string answer = "";

            for( int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            int divedeStr = s.Length % 2;
            if (divedeStr == 0)
            {
                answer = s[(s.Length / 2) - 1].ToString() + s[(s.Length / 2)].ToString();
            }
            else
            {
                answer = s[s.Length / 2].ToString();
            }

            Console.WriteLine(answer);


        }
    }
}
