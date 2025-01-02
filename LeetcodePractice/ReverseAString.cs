https://leetcode.com/problems/reverse-words-in-a-string/?envType=study-plan-v2&envId=leetcode-75

public class Solution {
    public string ReverseWords(string s) {
        // remove redundant first and last spaces
        s.Trim();
        // split string by empty space into many char arrays (each char array is a word)
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        // reverse array elements in an array in C#
        Array.Reverse(words);
        // concate the words and spaces
        return string.Join(" ", words);

    }
}