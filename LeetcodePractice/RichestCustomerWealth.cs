// problem: https://leetcode.com/problems/richest-customer-wealth/description/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int result = 0;
        for (int i = 0; i < accounts.Length; i++) {
            int sumRow = 0;
            for (int j = 0; j < accounts[0].Length; j++) {
                sumRow += accounts[i][j];
            }
            if (sumRow > result) {
                result = sumRow;
            }
        }
        return result;
    }
}