// problem: https://leetcode.com/problems/set-matrix-zeroes/description/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public void SetZeroes(int[][] matrix) {
        int col0 = matrix[0][0];
        int m = matrix.Length;
        int n = matrix[0].Length;
        for(int i = 0; i < m; i++) {
            for(int j = 0; j < n; j++) {
                if(matrix[i][j] == 0) {
                   matrix[i][0] = 0;
                   if(j == 0) {
                     col0 = 0;
                   }
                   else {
                     matrix[0][j] = 0;
                   }
                }
            }
        }

        for(int i = 1; i < m; i++) {
            for(int j = 1; j < n; j++) {
                if(matrix[i][0] == 0 || matrix[0][j] == 0) {
                        matrix[i][j] = 0;
                    }
            }
        }

        if(matrix[0][0] == 0) {
            int c = 0;
            while(c < n) {
                matrix[0][c++] = 0;S
            }
        }

        if(col0 == 0) {
            int r = 0;
            while(r < m) {
                matrix[r++][0] = 0;
            }
        }     
    }
}