// problem: https://leetcode.com/problems/monotonic-array/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public bool IsMonotonic(int[] nums) {
        // day don dieu
        // day tang/ day giam
        int len = nums.Length;
        int trend = 1; // 1: ascending, -1: descending
        if (nums[len - 1] < nums[0]) {
            trend = -1;
        }
        for (int i = 0; i < len - 1; i++) {
            if (trend == 1 && nums[i + 1] < nums[i]) {
                return false;
            } 
            if (trend == -1 && nums[i + 1] > nums[i]) {
                return false;
            } 
        }
        return true;
    }
}