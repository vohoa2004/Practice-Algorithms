// problem set: https://leetcode.com/problems/find-winner-on-a-tic-tac-toe-game/submissions/1481930583/?envType=study-plan-v2&envId=programming-skills

class Solution {
public:
    char findWinSymbol(char grid[3][3]) {
        if (grid[0][0] != ' ' && grid[0][0] == grid[1][1] && grid[1][1] == grid[2][2]) {
            return grid[0][0];
        }
        if (grid[2][0] != ' ' && grid[2][0] == grid[1][1] && grid[1][1] == grid[0][2]) {
            return grid[2][0];
        }
        for (int i = 0; i < 3; i++) {
            if (grid[i][0] != ' ' && grid[i][0] == grid[i][1] && grid[i][1] == grid[i][2]) {
                return grid[i][0];
            }
            if (grid[0][i] != ' ' &&grid[0][i] == grid[1][i] && grid[1][i] == grid[2][i]) {
                return grid[0][i];
            }
        }
        return 'D';
    }

public:
    string tictactoe(vector<vector<int>>& moves) {
        // brute force: consider all of 8 potential lines
        char grid[3][3];
        memset(grid, ' ', sizeof(grid));
        for (int k = 0; k < moves.size(); k++) {
            vector<int> move = moves[k];
            int i = move[0];
            int j = move[1];
            if (k % 2 == 0) {
                grid[i][j] = 'X';
            } else {
                grid[i][j] = 'O';
            }
        }
        char winSymbol = findWinSymbol(grid); 
        return winSymbol == 'X' ? "A" : winSymbol == 'O' ? "B" : moves.size() < 9 ? "Pending" : "Draw";
        
    }
};
