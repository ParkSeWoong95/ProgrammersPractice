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
                // 임시 리스트 생성
                List<int> temp = new List<int>(array);

                // 1~ 4까지 범위안의 값을 추가
                temp = temp.GetRange(commands[i, 0] - 1, commands[i, 1] - commands[i, 0] + 1);

                //정렬
                temp.Sort();

                // 정렬된 temp의 3번째 값 가져와서 answer[i]에 넣기
                answer[i] = temp[commands[i, 2] - 1];
            }
            return answer;
        }
    }
}
