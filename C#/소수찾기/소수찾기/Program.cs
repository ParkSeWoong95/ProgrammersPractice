using System;

namespace 소수찾기
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(1 % 2);
            PrimeNumber pn = new PrimeNumber();
            //int x = pn.solution(2);
            int y = pn.solution(10);
            //Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
