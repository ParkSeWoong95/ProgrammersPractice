package programmers;

public class SumOfRowColumn {
	public static void main(String[] args) {
		SumRowAndColumn rowAndCoulmn = new SumRowAndColumn();
		rowAndCoulmn.solution(new int[][] { { 1, 2 }, { 2, 3 } }, new int[][] {
				{ 3, 4 }, { 5, 6 } });
		// 원하는 값 {4,6},{7,9}가 들어있어야함
	}
}

class SumRowAndColumn {
	public int[][] solution(int[][] arr1, int[][] arr2) {
		int[][] answer = new int[arr1.length][arr1[0].length];
		for (int i = 0; i < arr1.length; i++) {
			for (int j = 0; j < arr1[0].length; j++) {
				answer[i][j] = arr1[i][j]+ arr2[i][j];
			}
		}
		return answer;
	}
}