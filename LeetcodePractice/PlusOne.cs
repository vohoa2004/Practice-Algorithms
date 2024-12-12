// problem list: https://leetcode.com/studyplan/programming-skills/
// problem: https://leetcode.com/problems/plus-one

public class Solution {
    public int[] PlusOne(int[] digits) {
        int len = digits.Length;
        for (int i = len - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i] += 1;
                return digits;
            } else {
                digits[i] = 0;
            }
        }
        if (digits[0] == 0) {
            int[] newDigits = new int[len + 1];
            newDigits[0] = 1;
            return newDigits;
        }
        return digits;
    }  

    // cach nay dung duoc cho phep cong 2 so bat ky luon
    public int[] PlusOneV1(int[] digits) {
        int len = digits.Length;
        Stack<int> resultStack = new Stack<int>();
        
        int carry = 0;
        for (int i = len - 1; i >= 0; i--) {
            if (i == len - 1) {
                carry = 1;
            }
            int current = digits[i] + carry;
            if (current > 9) {
                resultStack.Push(current - 10);
                carry = 1;
                if (i == 0) {
                    resultStack.Push(1);
                }
            }
            else {
                resultStack.Push(current);
                carry = 0;
            }
            
        }
        

        int[] result = new int[resultStack.Count];
        int j = 0;
        while (resultStack.Count != 0) {
            result[j++] = resultStack.Pop();
        }
        return result;
    }
}