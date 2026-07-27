public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        char[][] board = new char [n][];
        for(int i =0 ; i < n; i ++){
            board[i] =new char[n]; 
            Array.Fill(board[i], '.');
        }
    IList<IList<string>> result = new List<IList<string>>();
      
            nQueen(result, 0, n,board);
        return result;
    }

    private void nQueen(IList<IList<string>> result, int c, int n, char[][] board){

        if(c == n){
            List<string> temp = new();
            foreach(var ro in board){
                temp.Add(new string(ro));
            }
            result.Add(temp);
            return;
        }
        for(int r = 0; r < n; r++){
            if(isValid(c,r,board,n)){
                board[r][c] = 'Q';
                nQueen(result, c+1,n,board);
                board[r][c] = '.';
            }
        }
    }

 private bool isValid(int c, int r, char[][] board, int n){
    int copy_r = r;
    int copy_c = c;

    while(r >= 0 &&  c >= 0){
        if( board[r][c] == 'Q') return false;
        c--; r--;
    } 
     r = copy_r;
    c = copy_c;
    while(c  >= 0 ){
       if( board[r][c] == 'Q') return false;
           c--;
    }
   r = copy_r;
    c = copy_c;
    while ( c >= 0 && r < n){
         if( board[r][c] == 'Q') return false;
         c--; r++;
    }

    return true;
 }
}