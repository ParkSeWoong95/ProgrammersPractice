using System;
using System.Collections.Generic;
using System.Text;

namespace 콜라스추측
{
    class Class1
    {
        public static int solution(long num)
        {
            int count = 0;
            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num = num * 3 + 1;
                }
                count++;

                if (count == 500)
                {
                    count = -1;
                    break;
                }
            }
            // Console.WriteLine(count);
            return count;
        }
    }
}
