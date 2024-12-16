// problem: https://leetcode.com/problems/to-lower-case/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public string ToLowerCase(string s) {
        string result = "";
        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            if (s[i] >= 'A' && s[i] <= 'Z') {
                c = (char) ((int)s[i] + 32);
            }
            result += (c + "");
        }
        return result;
    }
}