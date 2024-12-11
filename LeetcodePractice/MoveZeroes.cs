// problem: https://leetcode.com/problems/move-zeroes/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int n = nums.Length;
        List<int> numsCopied = new List<int>();
        int m = 0;
        for (int i = 0; i < n; i++) {
            if (nums[i] != 0) {
                numsCopied.Add(nums[i]);
                m++;
            }
        }

        for (int i = 0; i < m; i++) {
            nums[i] = numsCopied[i];
        }
        for (int i = m; i < n; i++) {
            nums[i] = 0;
        }
    }
}