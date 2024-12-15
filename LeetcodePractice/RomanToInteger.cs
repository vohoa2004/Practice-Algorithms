// problem: https://leetcode.com/problems/roman-to-integer/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        int len = s.Length;
        char[] sCharArr = s.ToCharArray();

	// use switch-case instead of HashMap for better performance
        int Encode(char c) {
            switch(c) {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
        for (int i = 0; i < len - 1; i++) {
            if (Encode(sCharArr[i]) < Encode(sCharArr[i + 1])) {
                result -= Encode(sCharArr[i]);
            } else {
                result += Encode(sCharArr[i]);
            }
        }

        result += Encode(sCharArr[len - 1]);
        return result;
    }
}
