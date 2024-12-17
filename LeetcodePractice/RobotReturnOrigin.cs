// problem: https://leetcode.com/problems/robot-return-to-origin/submissions/1481152824/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public bool JudgeCircle(string moves) {
        int sumUD = 0;
        int sumRL = 0;
        foreach (char move in moves) {
            switch (move) {
                case 'U':
                    sumUD++;
                    break;
                case 'D':
                    sumUD--;
                    break;
                case 'R':
                    sumRL++;
                    break;
                case 'L':
                    sumRL--;
                    break;
            }
        }
        return sumUD == 0 && sumRL == 0;
    }
}