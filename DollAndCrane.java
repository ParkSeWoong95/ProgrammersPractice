package programmers;

import java.util.Stack;

public class DollAndCrane {
	public static void main(String[] args) {
		DollSolution ds = new DollSolution();
		ds.solution(new int[][] { { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 3 },
				{ 0, 2, 5, 0, 1 }, { 4, 2, 4, 4, 2 }, { 3, 5, 1, 3, 1 } },
				new int[] { 1, 5, 3, 5, 1, 2, 1, 4 }
		// new int[] { 0, 4, 2, 4, 0, 1, 0, 3 }
		);
	}
}

class DollSolution {
	public int solution(int[][] board, int[] moves) { // board 에서 인형이 사라지면 '0'으로
		int answer = 0;
		Stack<Integer> stack = new Stack<>();

		for (int i = 0; i < moves.length; i++) {
			for (int j = 0; j < board.length; j++) {
				if(board[j][moves[i]-1] > 0){
					if(stack.empty()){ // 스택이 비어있다면 넣기
						stack.push(board[j][moves[i]-1]);
					}
					else{ // 스택이 차있다. 다음 숫자가 들어오는게 마지막 스택숫자와 같다면 없애야함
						if(stack.peek() == board[j][moves[i]-1]){
							stack.pop();
							answer += 2;
						}else {
							stack.push(board[j][moves[i]-1]);
						}
					}
					board[j][moves[i]-1] = 0;
					break;
				}
			}
		}

		return answer;
	}
}