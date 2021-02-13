using System;
using System.Collections.Generic;
using System.Text;

namespace 하샤드_수
{
    class Solution
    {
        public static bool solution(int x)
        {
            int num = 0;
            int parameterX = x;
            while (x != 0)
            {
                num += x % 10;

                x /= 10;
            }

            if (parameterX % num == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
