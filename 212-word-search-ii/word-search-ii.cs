public class TrieNode{
    public readonly Dictionary<char,TrieNode> child;
    public bool is_word;
    public TrieNode(){
        child = new ();
        is_word = false;
    }
    public void AddWord(string word, TrieNode node){
       
       for(int i = 0; i< word.Length; i++){
        if(!node.child.ContainsKey(word[i])){
            node.child[word[i]] = new TrieNode();
        }
         node = node.child[word[i]];
       }
       node.is_word = true;
    }
}
public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        TrieNode root = new TrieNode();
        foreach(var word in words){
            root.AddWord(word, root);
        }
    HashSet<string> result = new();

        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[0].Length; c++)
            {
                DFS(r, c, result,board,root, "");
            }
        }

        return result.ToList();
    }
    private void DFS(int r, int c, HashSet<string> result,char[][] board, TrieNode root, string word){
        if(r < 0 || r >= board.Length || c <0 || c >= board[0].Length || 
            board[r][c] == '#'|| !root.child.ContainsKey(board[r][c]) ){
                return;
            }
           
            char ch =  board[r][c];
            word += ch;
            board[r][c] = '#';
            root = root.child[ch];
             if(root.is_word == true){
                result.Add(word);
            }
            DFS(r + 1, c,result, board, root,  word);
             DFS(r - 1, c,result, board, root, word);
             DFS(r, c + 1,result, board, root, word);
             DFS(r, c - 1,result, board, root, word);
            board[r][c] = ch;
    }
}