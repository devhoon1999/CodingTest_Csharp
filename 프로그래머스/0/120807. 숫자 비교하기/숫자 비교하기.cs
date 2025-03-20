using System;

public class Solution {
    public int solution(int num1, int num2) {
        bool isValid = (num1 >= 0 && num1 <= 10000) && (num2 >= 0 && num2 <= 10000);
        if (isValid)
        {
            return (num1 == num2) ? 1 : -1;
        }
        throw new ArgumentOutOfRangeException("num1과 num2는 0 이상 10,000 이하의 값이어야 합니다.");
    }
}