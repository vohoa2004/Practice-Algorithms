public class Solution {
    public void MoveZeroes(int[] nums) {
        // No copy array
        MoveZeroesV2(nums);
    }

    public void MoveZeroesV1(int[] nums) {
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

    public void MoveZeroesV2 (int[] nums) {
        // 2 pointer. Left and Right. Right go ahead, if nums[right] != 0 than swap right with left and increment left.
        // left pointer đóng vai trò đánh dấu vị trí đúng ra số right cần phải ở, nên chỉ tăng khi gặp số khác 0 để swap
        int left = 0;
        for (int right = 0; right < nums.Length; right++) {
            if (nums[right] != 0) {
                int temp = nums[right];
                nums[right] = nums[left];
                nums[left] = temp;
                left++;
            } 
        }


    }
}