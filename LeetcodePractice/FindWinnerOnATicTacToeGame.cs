public class Solution {
    private char FindWinSymbol(char[,] grid) {
        if (grid[0, 0] != ' ' && grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2]) {
            return grid[0, 0];
        }
        if (grid[2, 0] != ' ' && grid[2, 0] == grid[1, 1] && grid[1, 1] == grid[0, 2]) {
            return grid[2, 0];
        }

        for (int i = 0; i < 3; i++) {
            if (grid[i, 0] != ' ' && grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2]) {
                return grid[i, 0];
            }
            if (grid[0, i] != ' ' && grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i]) {
                return grid[0, i];
            }
        }

        return 'D';
    }

    public string Tictactoe(int[][] moves) {
        char[,] grid = new char[3, 3];
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                grid[i, j] = ' ';
            }
        }

        for (int k = 0; k < moves.Length; k++) {
            int i = moves[k][0];
            int j = moves[k][1];
            if (k % 2 == 0) {
                grid[i, j] = 'X';
            } else {
                grid[i, j] = 'O'; 
            }
        }

        char winSymbol = FindWinSymbol(grid);
        if (winSymbol == 'X') {
            return "A"; 
        } else if (winSymbol == 'O') {
            return "B";
        } else if (moves.Length < 9) {
            return "Pending"; 
        } else {
            return "Draw"; 
        }
    }
}
