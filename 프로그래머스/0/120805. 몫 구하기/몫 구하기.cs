using System;

public class Solution {
    public int solution(int num1, int num2) {
        bool isValid = (num1 > 0 && num1 <= 100) && (num2 > 0 && num2 <= 100);
        if (isValid)
        {
            int answer = num1 / num2;
            return answer;
        }
        throw new ArgumentOutOfRangeException("num1과 num2는 1 이상 100 이하의 값이어야 합니다.");
    }
}