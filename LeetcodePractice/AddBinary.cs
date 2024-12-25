// problem: https://leetcode.com/problems/add-binary/?envType=study-plan-v2&envId=programming-skills

class Solution {
    public String AddBinary(String a, String b) {
        int n = a.Length;
        int m = b.Length;
        if (m > n) {
            return AddBinary(b, a);
        }
        // n > m <=> a dai hon b
        char[] result = new char[n];
        int carry = 0;
        int j = m - 1;
        for (int i = n - 1; i >= 0; i--) {
            // find the sum of each place
            int sum = a[i] - '0' + carry;
            if (j >= 0) {
                sum += b[j] - '0';
                j--;
            }
            // digit = remainder of sum when divide 2
            int digit = sum % 2;
            // carry = quotient of sum when divide 2
            carry = sum / 2;
            result[i] = (char)(digit + '0');
        }
        if (carry > 0) {
            return '1' + new string(result);
        }
        return new string(result);
    }
}
