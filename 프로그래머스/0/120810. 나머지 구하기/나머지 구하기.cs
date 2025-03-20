using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        bool isValid = (0 < num1 && num1 <= 100) || (0 < num2 && num2 <= 100);
        if (isValid)
        {
            answer = num1 % num2;
            return answer;
        }
        throw new Exception("num1, num2 는 0보다 크고 100보다 작거나 같아야 합니다.");
    }
}