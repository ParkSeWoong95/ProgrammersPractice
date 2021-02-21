package programmers;

public class CaesarCipher {
	public static void main(String[] args) {
		CaesarSolution.solution("AB", 1); // BC
		CaesarSolution.solution("a B z", 4); // e F d

	}
}

class CaesarSolution {
	public static String solution(String s, int n) {
		String answer = "";
		for(int i = 0; i< s.length(); i++){
			char ch = s.charAt(i);
			if(ch >= 'a' && ch <= 'z'){
				ch = (char)(n+ch);
				if(ch > 'z'){
					ch -= 26;
				}
			}else if(ch >= 'A' && ch <= 'Z'){
				ch = (char)(n+ch);
				if(ch > 'Z'){
					ch -= 26;
				}
			}
			answer += ch;
		}
		
		return answer;
	}
}