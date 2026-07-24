public class Solution {
    public bool Exist(char[][] board, string word) {
         int row = board.Length;
         int col = board[0].Length;
         HashSet<(int, int)> used = new();

         for(int r= 0; r < row; r++){
            for(int c = 0; c < col; c++){
                if(Match(board, word,r,c,0,used)){
                    return true;
                }
            }
         } 
        return false;   
    }
    private bool Match(char[][] board, string word,int r, int c, int index, HashSet<(int,int)> used){
        if(index == word.Length) return true;

        if(r < 0 || c < 0 || r >= board.Length || c >= board[0].Length){
                return false;
        }   
        // current letter no matching with result index
        if(board[r][c] != word[index]){
            return false;
        }
        // alreadu used
        if(used.Contains((r,c))) return false;

        // add
        used.Add((r,c));

        // track
        bool found = Match(board, word,r +1,c,index +1 ,used) ||
                     Match(board, word,r -1,c,index +1 ,used) ||  
                     Match(board, word,r ,c +1,index +1 ,used) || 
                     Match(board, word,r,c -1,index +1 ,used);

        used.Remove((r,c));  
        return found;                   
    }
}