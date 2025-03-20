using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        bool isValid = (num1 >= -50000 && num1 <= 50000) && (num2 >= -50000 && num2 <= 50000);
        if (isValid) 
        {
            answer = num1 - num2;
            return answer;
        }
        throw new ArgumentOutOfRangeException("num1과 num2는 -50000 이상 50000 이하의 값이어야 합니다.");
    }
}