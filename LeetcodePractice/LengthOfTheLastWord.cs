// problem: https://leetcode.com/problems/length-of-last-word/description/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public int LengthOfLastWord(string s) {
        string trimS = s.Trim();
        int len = trimS.Length;
        int indexOfLastSpace = len - 1;
        for (int i = len - 1; i >= 0; i--) {
            if (trimS[i] == ' ') {
                indexOfLastSpace = i;
                break;
            }
        }
        if (indexOfLastSpace == len - 1) {
            return len;
        }
        return len - indexOfLastSpace - 1;
    }
}