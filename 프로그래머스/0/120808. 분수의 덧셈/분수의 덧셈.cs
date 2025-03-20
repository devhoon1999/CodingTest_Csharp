using System;

public class Solution 
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2) 
    {
        int commonDenom = denom1 * denom2;  
        int newNumer = (numer1 * denom2) + (numer2 * denom1);
        int gcdValue = GCD(newNumer, commonDenom);
        int[] answer = new int[] { newNumer / gcdValue, commonDenom / gcdValue };
        return answer;
    }
    private int GCD(int a, int b) 
    {
        while (b != 0) 
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a); // 절대값 반환 (음수 방지)
    }
}