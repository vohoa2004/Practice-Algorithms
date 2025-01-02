https://leetcode.com/problems/greatest-common-divisor-of-strings/?envType=study-plan-v2&envId=leetcode-75

public class Solution {
    private int gcd(int a, int b) {
        // assume a > b
        int result = b;
        while (a > b) { // chu y dieu kien la a > b
            if (b == 0) {
                result = a;
                break;
            }
            int r = a % b;
            a = b;
            b = r;
        }
        return result;
    }
    public string GcdOfStrings(string str1, string str2) {
        // nx quan trong, co the dung trong nhieu bai: neu str1 va str2 co GCD => str1 + str2 phai == str2 + str1
        // neu str1 + str2 != str2 + str1 => GCD = ""
        if (!(str1 + str2).Equals(str2 + str1)) {
            return "";
        }

        // tim GCD string => string co do dai = GCD(str1.len, str2.len) => ca str1 va str2 tao tu mot so nguyen lan noi nhau cua chuoi do
        int l1 = str1.Length, l2 = str2.Length;
        int gcdLen = l1 > l2 ? gcd(l1, l2) : gcd(l2, l1);
        return str1.Substring(0, gcdLen);
    }
}