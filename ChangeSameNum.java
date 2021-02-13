package programmers;

import java.util.ArrayList;
import java.util.List;

public class ChangeSameNum {
	public static void main(String[] args) {
		changeNumber.solution(new int[] { 1, 1, 3, 3, 0, 1, 1 });
		changeNumber.solution(new int[] { 4, 4, 4, 3, 3 });
		// changeNumber.solution(new int[] { 2, 2, 2, 4, 4, 4, 0, 1, 1, 1, 0, 0
		// });

	}
}

class changeNumber {
	public static int[] solution(int[] arr) {
		List<Integer> list = new ArrayList<Integer>();
		int num = 10;
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] != num) {
				list.add(arr[i]);
				num = arr[i];
			}
		}
		int[] answer = new int[list.size()];
		for (int i = 0; i < list.size(); i++) {
			answer[i] = list.get(i);
		}
		return answer;
	}
}
