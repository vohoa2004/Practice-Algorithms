// problem: https://leetcode.com/problems/sign-of-the-product-of-an-array/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public int ArraySign(int[] nums) {
        int prod = 1;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < 0) {
                prod *= (-1);
            } else if (nums[i] == 0) {
                prod = 0;
                break;
            }
        }
        return prod;
    }
}