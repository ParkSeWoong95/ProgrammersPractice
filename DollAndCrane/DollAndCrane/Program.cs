using System;

namespace DollAndCrane
{
    class Program
    {
        static void Main(string[] args)
        {
            DollSolution ds = new DollSolution();
            ds.solution(new int[,]  {
                                            { 0, 0, 0, 0, 0 },
                                            { 0, 0, 1, 0, 3 },
                                            { 0, 2, 5, 0, 1 },
                                            { 4, 2, 4, 4, 2 },
                                            { 3, 5, 1, 3, 1 }
                                             },
              new int[] { 1, 5, 3, 5, 1, 2, 1, 4 });
        }
    }

    class DollSolution
    {
        public int solution(int[,] board, int[] moves)
        {
            int answer = 0;
            int[] dollArr = new int[8];
            // 1. for문을 돌면서 새롭게 만들어진 배열에 담겨져야함
            // if(board[i][moves[i]]>0){
            //
            // }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0,0]; j++)
                {
                    if (board[i,j] > 0)
                    {
                        dollArr[i] = board[i,j];
                    }
                }
            }



            return answer;
        }

    }
}
