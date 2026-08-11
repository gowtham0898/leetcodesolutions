public class TrieNode{
    public readonly Dictionary<char,TrieNode> childern;
    public bool is_word;
    public TrieNode(){
        childern = new();
        is_word = false;
    }

    public void AddWord(string word, TrieNode node){
        foreach(var ch in word){
            if(!node.childern.ContainsKey(ch)){
                node.childern[ch] = new TrieNode();    
            }   
            node = node.childern[ch];
        }
        node.is_word = true;
        
    }
}
public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        TrieNode root = new TrieNode();
        foreach(var word in words){
            root.AddWord(word,root);
        }
           HashSet<(int,int)> set = new();
            HashSet<string> result = new();
            for(int r = 0; r < board.Length; r++ ){
                for(int c = 0; c < board[0].Length; c++ ){
                     DFS(r,c,root,board,set,result,"");
                }
            }
            return result.ToList();
    }
    private void DFS(int r, int c,TrieNode root,char[][] board,HashSet<(int,int)> set,HashSet<string> result, string word){

        if(r < 0 || r >= board.Length || c  < 0 || c >=board[0].Length||
            board[r][c] == '#' || !root.childern.ContainsKey(board[r][c])){
            return;
           }
           //set.Contains((r,c))
           //set.Add((r,c));
           char ch = board[r][c];
           word += board[r][c];
           root = root.childern[board[r][c]];
           if(root.is_word){
            result.Add(word);
           }
            board[r][c] = '#';
           DFS(r+1,c,root,board,set,result,word);
           DFS(r-1,c,root,board,set,result,word);
           DFS(r,c+1,root,board,set,result,word);
           DFS(r,c-1,root,board,set,result,word);
           //set.Remove((r,c));
           board[r][c] = ch;
    }
}