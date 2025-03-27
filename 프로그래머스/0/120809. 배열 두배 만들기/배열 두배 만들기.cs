using System;

public class Solution {
    public int[] solution(int[] numbers)
{
    int[] answer = new int[numbers.Length];
    bool isValidLength = (numbers.Length >= 1) && (numbers.Length <= 1000);
    bool isValidSize = true;
    foreach (int num in numbers)
    {
        if (num < -10000 || num > 10000)
        {
            isValidSize = false;
            break;
        }
    }
    if (isValidSize && isValidLength)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            answer[i] = numbers[i] * 2;
        }
    }
    return answer;
}
}