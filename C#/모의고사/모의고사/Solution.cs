using System;
using System.Collections.Generic;

namespace 모의고사
{
    public class Solution
    {
        public int[] solution(int[] answers)
        {
            List<int> list = new List<int>();
            // 답안지 배열
            int[] first = new int[] { 1, 2, 3, 4, 5 };
            int[] second = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] third = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            // 정답자 배열
            int[] score = new int[3];

            for (int i = 0; i < answers.Length; i++)
            {
                if (first[i % 5] == answers[i])
                {
                    score[0]++;
                }
                if (second[i % 8] == answers[i])
                {
                    score[1]++;
                }
                if (third[i % 10] == answers[i])
                {
                    score[2]++;
                }
            }

            int[] max = new int[3];
            for (int i = 0; i < score.Length; i++)
            {
                if (score[0] >= score[1] && score[0] >= score[2])
                {
                    max[0] = 1;
                }
                if (score[1] >= score[2] && score[1] >= score[0])
                {
                    max[1] = 2;
                }
                if (score[2] >= score[0] && score[2] >= score[1])
                {
                    max[2] = 3;
                }
            }

            for (int i = 0; i < max.Length; i++)
            {
                if (max[i] > 0)
                {
                    list.Add(max[i]);
                }
            }

            int[] result = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                result[i] = list[i];
            }
            return result;
        }
    }
}
