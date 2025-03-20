using System;

public class Solution {
    public int solution(int age) {
        int answer = 0;
        bool isValid = (0 < age && age <= 120);
        if (isValid)
        {
            answer = 2022 - age + 1;
            return answer;
        }
        throw new ArgumentOutOfRangeException("age 는 0보다 크고 120보다 작거나 같아야 합니다.");
    }
}