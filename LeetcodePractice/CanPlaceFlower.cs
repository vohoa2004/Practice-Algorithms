https://leetcode.com/problems/can-place-flowers/description/?envType=study-plan-v2&envId=leetcode-75

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int countPossibleSlot = 0;
        for (int i = 0; i < flowerbed.Length; i++) {
            // check if current place is empty && its left and right place is empty too
            if (flowerbed[i] == 0) {
                bool isEmptyLeft = (i == 0) || (flowerbed[i - 1] == 0); // if left has no element or left is empty
                bool isEmptyRight = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);
                if (isEmptyLeft && isEmptyRight) {
                    flowerbed[i] = 1; // plant it right when find it empty to make sure that later loop not add it more that can lead mistake
                    countPossibleSlot++;
                }
            }
        }
        return countPossibleSlot >= n;
    }
}