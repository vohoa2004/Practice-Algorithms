https://leetcode.com/problems/product-of-array-except-self/submissions/1495163136/?envType=study-plan-v2&envId=leetcode-75

public class Solution {
    // prefix_i = product of all numbers from nums[0] to nums[i - 1]
    // suffix_i = product of all numbers from nums[i + 1] to nums[n - 1]
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int suffix = 1; // khoi tao tich suffix_(n-1) = 1 (sau phan tu cuoi khong con so nao)
        int prefix = 1; // khoi tao tich prefix_(0) = 1 (truoc phan tu dau khong con so nao)
        int[] result = new int[n];
        for (int i = 0; i < n; i++) {
            result[i] = 1;
        }
        for (int i = 0; i < n; i++) {
            result[i] *= prefix; // nhan xong roi moi cap nhat prefix cho so nums[i + 1] vi prefix_i = nums[0] * ... * nums[i - 1]
            prefix *= nums[i];
        }
        for (int i = n - 1; i >= 0; i--) {
            result[i] *= suffix; // nhan xong roi moi cap nhat prefix cho so nums[i + 1] vi prefix_i = nums[0] * ... * nums[i - 1]
            suffix *= nums[i];
        }
        return result;
    }
}