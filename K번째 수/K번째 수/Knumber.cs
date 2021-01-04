using System;
using System.Collections.Generic;
using System.Text;

namespace K번째_수
{
    class Knumber
    {
        public static int[] FindKArray(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                List<int> temp = new List<int>(array);
                temp = temp.GetRange(commands[i, 0] - 1, commands[i, 1] - commands[i, 0] + 1);
                temp.Sort();
                answer[i] = temp[commands[i, 2] - 1];
            }
                return answer;
        }
    }
}
