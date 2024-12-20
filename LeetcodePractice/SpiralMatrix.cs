// problem: https://leetcode.com/problems/spiral-matrix/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> result = new List<int>();
        // spiral ~ first row -> last column -> last row -> first column 
        int row = matrix.Length;
        int col = matrix[0].Length;
        
        // when problem is related to direction => create variable direction to keep track with the direction
        int d = 0; // 0: left -> right, 1: top -> bottom, 2: left -> right, 3: bottom -> top
        
        int top = 0, bottom = row - 1;
        int left = 0, right = col - 1;
        while (top <= bottom && left <= right) {
            // left -> right
            if (d == 0) {
                for (int i = left; i <= right; i++) {
                    result.Add(matrix[top][i]);
                }
                top++;
                d = 1;
            } else if (d == 1) {
                for (int i = top; i <= bottom; i++) {
                    result.Add(matrix[i][right]);
                }
                right--;
                d = 2;
            } else if (d == 2) {
                for (int i = right; i >= left; i--) {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
                d = 3;
            } else {
                for (int i = bottom; i >= top; i--) {
                    result.Add(matrix[i][left]);
                }
                left++;
                d = 0;
            }
        }
        return result;
    }
}