public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        char[][] board = new char[n][];
        for(int i =0; i < n; i++){
           board[i] = new char[n];
           Array.Fill(board[i], '.');
        }
         IList<IList<string>> result = new List<IList<string>>();
           
                solve(board,0,n,result);
            return result;
    }
    private void solve(char[][] board,int c, int n, IList<IList<string>> result){
        if(c == n){
            List<string> temp = new();
            foreach(var res in board){
                temp.Add(new string(res));
            }
            result.Add(temp);
            return;
        }
        for(int r = 0; r<n;r++){
            if(isValid(r,c,n, board)){
               board[r][c]  = 'Q';
               solve(board,c+1,n,result);
                 board[r][c]  = '.';
            }
        }
    }

    private bool isValid(int r, int c, int n, char[][] board){
        int copy_c = c;
        int copy_r = r;
        while(r >= 0 && c >= 0){
            if(board[r][c] == 'Q'){
                return false;
            }
            r--;c--;
        }
        c = copy_c;
        r = copy_r;
        while(c >= 0){
             if(board[r][c] == 'Q'){
                return false;
            }
            c--;
        }
        c = copy_c;
        r = copy_r;
        while(r < n &&  c >= 0){
             if(board[r][c] == 'Q'){
                return false;
            }
           r++;c--;
        }
        return true;
    }

}