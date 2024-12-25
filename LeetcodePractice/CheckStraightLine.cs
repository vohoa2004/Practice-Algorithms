// problem: https://leetcode.com/problems/check-if-it-is-a-straight-line/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        // viet ptr dthang di qua 2 diem
        // check may diem con lai
        int x1 = coordinates[0][0], y1 = coordinates[0][1];
        int x2 = coordinates[1][0], y2 = coordinates[1][1];
        if (x1 == x2) {
            for (int i = 2; i < coordinates.Length; i++) {
                if (coordinates[i][0] != x1) {
                    return false;
                }
            }
            return true;
        }
        double a = (double)(y1 - y2)/(double)(x1 - x2);
        double b = y1 - a * x1;
        for (int i = 2; i < coordinates.Length; i++) {
            if ((double)coordinates[i][1] != (double)a * coordinates[i][0] + b) {
                return false;
            }
        }
        return true;
    }
}

