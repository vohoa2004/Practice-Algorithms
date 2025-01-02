https://leetcode.com/problems/reverse-vowels-of-a-string/?envType=study-plan-v2&envId=leetcode-75

public class Solution {
    public string ReverseVowels(string s) {
        // reverse ban chat la swap 2 dau voi nhau => 2 pointers
        int n = s.Length;
        int left = 0, right = n - 1;
        char[] sArr = s.ToCharArray();
        while (left < right) {
            if (!IsVowel(sArr[left]) && left < right) left++; // neu ky tu ben trai ma khong phai vowel => left move on
            if (!IsVowel(sArr[right]) && left < right) right--; // neu ky tu ben phai ma khong phai vowel => right move on
            if (IsVowel(sArr[left]) && IsVowel(sArr[right])) { // chi swap khi ca 2 la vowel
                char temp = sArr[left];
                sArr[left] = sArr[right];
                sArr[right] = temp;
                right--;
                left++;
            }
        }
        return new string(sArr);
    }

    private bool IsVowel(char c) {
        return c == 'a' || c == 'A' || c == 'e' || c == 'E' || c =='o' || c == 'O' 
        || c == 'i' || c == 'I' || c == 'u' || c == 'U';
    }
}