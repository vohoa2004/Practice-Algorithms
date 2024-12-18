// problem: https://leetcode.com/problems/robot-bounded-in-circle/?envType=study-plan-v2&envId=programming-skills

class Solution {
public:
    bool isRobotBounded(string instructions) {
        // (x, y) is coordinate of robot
        int x = 0; 
        int y = 0;
        int d[4][2] = {{0, 1}, {1, 0},  {0,-1}, {-1, 0}}; // N=0 - E=1 - S=2 - W=3 clock-wise
        int i = 0; // i is index to indicate current direction d
        for (char &c : instructions) {
            if (c == 'R') {
                // turn right - EAST => index of EAST direction = 1
                i = (i + 1) % 4; 
            }
            if (c == 'L') {
                // turn left - WEST => index of WEST direction = 3
                i = (i + 3) % 4;
            }
            if (c == 'G') { // only when the step is GO UP, we can add distance of direction to x and y coordinations
                x += d[i][0];
                y += d[i][1];
            }
        }
        return (x == 0 && y == 0) || (i != 0);
    }
};