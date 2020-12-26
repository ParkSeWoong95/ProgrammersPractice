using System;
using System.Collections.Generic;
using System.Text;

namespace ChoseTwoNum
{
    class Plustwonum
    {
        public static int[] solution(int[] numbers)
        {
            List<int> numArray = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    numArray.Add(sum);
                }
            }

            // List<int> numArray = {3,5,6,3,4,8,2,7,4,5}; 
            for (int i = 0; i < numArray.Count; i++)
            {
                for (int j = 0; j < numArray.Count; j++)
                {
                    if (numArray[j] == numArray[i])
                    {
                        int temp = numArray[i];
                        numArray.RemoveAll(x => x == numArray[i]);
                        numArray.Add(temp);
                    }
                }
            }


            // List<int> numArray = {5,3,2,4,7,6}
            for (int i = 0; i < numArray.Count; i++)
            {
                for (int j = i + 1; j < numArray.Count; j++)
                {
                    if (numArray[i] > numArray[j])
                    {
                        int temp = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = temp;
                    }
                }
            }

            int[] answer = new int[numArray.Count];
            for (int i = 0; i < numArray.Count; i++)
            {
                answer[i] = numArray[i];
            }


            for (int i = 0; i < numArray.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }

            return numbers;

        }
    }
}
