public class Solution {
    public bool IsValidSudoku(char[][] board) {
       HashSet<char> validNums = new HashSet<char>();

       foreach(var row in board){
        foreach(var cell in row){
            if(validNums.Contains(cell)){
                return false;
            }
            if(cell != '.'){
                validNums.Add(cell);
            }
        }
        validNums.Clear();
       }

        validNums.Clear();
        for(int i = 0; i < 9; i++){
            foreach(var row in board){
                if(validNums.Contains(row[i])){
                    return false;
                }
                if(row[i] != '.'){
                    validNums.Add(row[i]);
                }
            }
            validNums.Clear();
        }

        for(int square = 0; square < 9; square++){
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    int _x = (square/3)*3+i;
                    int _y = (square%3)*3+j;
                    if(validNums.Contains(board[_x][_y])){
                        return false;
                    }
                    if(board[_x][_y] != '.'){
                        validNums.Add(board[_x][_y]);
                    }
                }
            }
            validNums.Clear();
        }
        return true;
    }
}
