// problem: https://leetcode.com/problems/matrix-diagonal-sum/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public int DiagonalSum(int[][] mat) {
        int n = mat.Length;
        int sum = 0;
        for (int i = 0; i < n; i++) {
            sum += mat[i][i];
            sum += mat[n - 1 - i][i];
        }
        if (n % 2 != 0) {
            sum -= mat[(n - 1)/2][(n - 1)/2];
        }
        return sum;
    }
}