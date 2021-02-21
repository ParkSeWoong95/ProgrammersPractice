package programmers;

public class SecretMap {
	public static void main(String[] args) {
		Solution so = new Solution();
		so.solution(5, new int[] { 9, 20, 28, 18, 11 }, new int[] { 30, 1, 21,
				17, 28 });
	}
}

class Solution {
	public String[] solution(int n, int[] arr1, int[] arr2) {
		 String[] answer = new String[n];
			for(int i = 0; i < n; i++){
				String temp = Integer.toBinaryString(arr1[i] | arr2[i]);
				temp = String.format("%"+ n + "s", temp);
				temp = temp.replace("1", "#");
				temp = temp.replace("0", " ");
				System.out.println(temp);
				answer[i] = temp;
			}
			return answer;
	}
}
