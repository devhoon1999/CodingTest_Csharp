using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer;
        bool isValid = (0 < num1 && num1 <= 100) && (0 < num2 && num2 <= 100);
        if (!isValid) 
        {
            throw new ArgumentOutOfRangeException("num1, num2는 0보다 크고 100 이하이어야 합니다.");
        }
        if (num2 == 0) 
        {
            throw new DivideByZeroException("num2는 0이 될 수 없습니다.");
        }
        answer = num1 % num2;
        return answer;
    }
}