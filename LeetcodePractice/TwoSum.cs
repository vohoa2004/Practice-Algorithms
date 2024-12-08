// problem: https://neetcode.io/problems/two-integer-sum
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> setNums = new HashSet<int>();
        int[] indexes = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            if (setNums.Contains(target - nums[i])) {
                indexes[1] = i;
                break;
            }
            setNums.Add(nums[i]);
        }
        int i2 = indexes[1];
        for (int j = 0; j < i2; j++) {
            if (target - nums[i2] == nums[j]) {
                indexes[0] = j;
            }
        }
        return indexes;
    }
}
