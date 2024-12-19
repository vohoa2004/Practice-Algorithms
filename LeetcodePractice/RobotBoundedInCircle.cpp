class Solution {
public:
    bool isRobotBounded(string instructions) {
        // (x, y) is coordinate of robot
        int x = 0; 
        int y = 0;
        int d[4][2] = {{0, 1}, {1, 0},  {0,-1}, {-1, 0}}; // N=0 - E=1 - S=2 - W=3 clockwise
        int i = 0; // i is index to indicate current direction d
        for (char &c : instructions) {
            if (c == 'R') {
                // turn right - EAST => go to next direction to the right of array d (because direction d are sorted in d array clockwise)
                i = (i + 1) % 4; 
            }
            if (c == 'L') {
                // turn left - WEST => go to the next direction to the left of array d(an-ti clockwise)
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