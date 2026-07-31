public class Solution {
    public bool Exist(char[][] board, string word) {
        HashSet<(int,int)> occur = new();
        for(int r = 0 ; r < board.Length; r++){
            for(int c = 0 ; c < board[0].Length; c++){
                if(Solve(r,c,0,board,word,occur)) return true;
            }
        }
        return false;
    }
    private bool Solve(int r, int c, int i,char[][] board, string word, HashSet<(int,int)> occur){
        int row = board.Length -1; int col = board[0].Length -1;
        if(i == word.Length){
            return true;
        }        
        if( r < 0 || c < 0 || r > row || c >col||
            word[i] != board[r][c] || occur.Contains((r,c))){
                return false;
            }
         occur.Add((r,c));
         var res = (Solve(r +1,c,i+1,board,word,occur)||
                    Solve(r -1,c,i+1,board,word,occur)||
                    Solve(r,c+1,i+1,board,word,occur)||
                    Solve(r,c-1,i+1,board,word,occur));
                    occur.Remove((r,c));
            return res;   
    }
}