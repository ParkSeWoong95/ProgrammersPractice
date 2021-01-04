using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace 약수의_합
{
    class Solution
    {
        public static int solution(int n)
        {
            List<int> x = new List<int>();
            List<int> y = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    x.Add(1);
                }
                else
                {
                    x.Add(n / i);
                }
            }

            for (int i = 0; i < x.Count; i++)
            {
                for (int j = 0; j < x.Count; j++)
                {
                    if( n == x[i] * x[j])
                    {
                        y.Add(x[i]);
                        y.Add(y[i]);
                    }
                    int temp1 = x[i];
                    int temp2 = x[j];
                    // List<int> y 내에 중복되는 수 모두 없애기
                    // List<int> y 내의 모든 값의 합 

                }
            }


            return n;
        }
    }
}
