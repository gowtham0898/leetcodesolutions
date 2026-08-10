public class TrieNode{
    private readonly Dictionary<char,TrieNode> root;
    private bool flag;
    public TrieNode(){
        root = new();
        flag = false;
    }
    public bool ContainsKey(char ch){
        return root.ContainsKey(ch);
    }
    public void put(char ch, TrieNode node){
        root[ch] = node;
    }
    public TrieNode get(char ch){
        return root[ch];
    }
    public void setflag(){
        flag = true;
    }
      public bool getflag(){
        return flag;
    }
    public IEnumerable<TrieNode> GetChildren(){
        return root.Values;
    }
}

public class WordDictionary {
    private readonly TrieNode root;
    public WordDictionary() {
         root = new();
    }
    
    public void AddWord(string word) {
      TrieNode cur_node = root;  
      for(int i = 0; i < word.Length; i++){
        if(!cur_node.ContainsKey(word[i])){
            cur_node.put(word[i], new TrieNode());
        }
        cur_node = cur_node.get(word[i]);
      }
      cur_node.setflag();
    }
    
    public bool Search(string word) {
       return DFS(root,0,word);
    }
    public bool DFS(TrieNode node,int index, string word){
        if(index == word.Length){
            return node.getflag();
        }
        if(word[index] != '.'){
            if(!node.ContainsKey(word[index])){
                return false;
            }   
            var next_node = node.get(word[index]);
           return DFS(next_node,index +1, word);
        }
        if(word[index] =='.'){
            foreach(var node_val in node.GetChildren()){
                if(DFS(node_val,index +1, word)){
                    return true;
                }
            }
        }
        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */