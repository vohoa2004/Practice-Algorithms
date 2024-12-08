// Problem set: https://leetcode.com/studyplan/programming-skills/
// Problem: https://leetcode.com/problems/valid-anagram/

public class Solution {
    public bool IsAnagram(string s, string t) {
        bool isAnagram = true;
        if (s.Length != t.Length) {
            return false;
        }
        // count character frequency in O[n], no need hashmap, just use an array of 26 character!
        int[] sFrequency = new int[26];
        int[] tFrequency = new int[26];
        foreach (char sChar in s) {
            sFrequency[sChar - 'a']++;
        }
        foreach (char tChar in t) {
            tFrequency[tChar - 'a']++;
        }
        foreach (char i in s) {
            if (sFrequency[i - 'a'] != tFrequency[i - 'a']) {
                isAnagram = false;
                break;
            }
        }
        return isAnagram;
    }
}