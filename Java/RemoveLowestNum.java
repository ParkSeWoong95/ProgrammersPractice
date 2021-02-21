package programmers;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class RemoveLowestNum {
	public static void main(String[] args) {
		RemoveNum.solution(new int[] { 4, 3, 2, 1 });
		// RemoveNum.solution(new int[] { 7, 5, 4, 8 });
		// RemoveNum.solution(new int[] { 10 });
	}
}

class RemoveNum {
	public static int[] solution(int[] arr) { // sort필요 없이 하나의 원소가 모든 배열을 돌면서 비교
		if(arr.length <=1){
			return new int[]{-1};
		}
		
		List<Integer> list = new ArrayList<>();
		for(int i = 0; i< arr.length; i++){
			list.add(arr[i]);
		}
		int min = Collections.min(list);
//		System.out.println(min); // 값 "1"
		int index_min = list.indexOf(min);
//		System.out.println(index_min);
		list.remove(index_min);
//		System.out.println(list);
		
		int[] answer = new int[list.size()];
		for(int i = 0; i< answer.length; i++){
			answer[i] = list.get(i);
		}
		return answer;
	}
}
