public class Solution {
    public bool IsValidSudoku(char[][] board) {
       Dictionary<int, HashSet<char>> row = new Dictionary<int, HashSet<char>>();
       Dictionary<int, HashSet<char>> col = new Dictionary<int, HashSet<char>>();
       Dictionary<string, HashSet<char>> square = new Dictionary<string, HashSet<char>>();
       for(int i = 0; i < 9; i++){
        for(int j = 0; j < 9; j++){
            if(board[i][j] == '.'){
                continue;
            }
            string squareKey = i/3 + "," + j/3;
            if((row.ContainsKey(i) && row[i].Contains(board[i][j])) ||
                (col.ContainsKey(j) && col[j].Contains(board[i][j])) ||
                (square.ContainsKey(squareKey) && square[squareKey].Contains(board[i][j]))){
                    return false;
                }

            if(!row.ContainsKey(i)){
                row[i] = new HashSet<char>();
            }
            if(!col.ContainsKey(j)){
                col[j] = new HashSet<char>();
            }
            if(!square.ContainsKey(squareKey)){
                square[squareKey] = new HashSet<char>();
            }

            row[i].Add(board[i][j]);
            col[j].Add(board[i][j]);
            square[squareKey].Add(board[i][j]);
       }
    }
    return true;
}
}
