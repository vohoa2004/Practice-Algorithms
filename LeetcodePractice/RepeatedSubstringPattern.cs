// problem set: https://leetcode.com/studyplan/programming-skills/
// https://leetcode.com/problems/repeated-substring-pattern
// if s can made from multiple subStr, the start character of subStr must be s[0]
// EX: invalid s: rabcrabcdabc
public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        //return RepeatedSubstringPatternOld(s);
        //return RepeatedSubstringPatternOptimizedV1(s);
        return RepeatedSubstringPatternOptimizedV2(s);
    }

    public bool RepeatedSubstringPatternOld(string s) {
        bool result = false;
        int strLen = s.Length;

        List<string> subStrCandidates = new List<string>();
        for (int i = 1; i <= strLen; i++) {
            if (strLen % i == 0) {
                string subStr = s.Substring(0, i);
                subStrCandidates.Add(subStr);
            }
        }
        foreach (string ss in subStrCandidates) {
            string check = "";
            int subStrLen = ss.Length;
            int loopTimes = strLen/subStrLen;
            if (loopTimes > 1) {
                for (int i = 1; i <= loopTimes; i++) {
                    check += ss;
                }
            }
            if (check.Equals(s)) {
                result = true;
                break;
            }
        } 
        return result;
    }

    public bool RepeatedSubstringPatternOptimizedV1(string s) {
        // idea: concatenate the string with itself. If it is a matched string, the original string will occur one more time before last occurence
        // ex: abab -> concat: abababab -> abab occured at index 2, before final occurence at index 4 (4 == length of original string, because we concat original string with itself)
        // ex2: abcdabcd -> there is no additinal occurence before last occurence at index 4! => invalid string

        //Note: hàm substring java là (start, end + 1)
        // hàm Substring C# là (start, length)
        string doubledStr = s + s;
        int strLen = s.Length;
        for (int i = 1; i < strLen; i++) {
            if (doubledStr[i] == s[0] && doubledStr.Substring(i, strLen).Equals(s)) {
                return true;
            }
        }
        return false;
    }

    public bool RepeatedSubstringPatternOptimizedV2(string s) {
        // idea: giống V1 thôi
        string doubledStr = s + s;  
        int strLen = s.Length;      
        return doubledStr.Substring(1, strLen * 2 - 2).Contains(s);
    }
}