public class TrieNode{
    public readonly Dictionary<char,TrieNode> node;
    public bool is_word;
    public TrieNode(){
        node = new();
        is_word = false;
    }

    public bool ContainsKey(char ch){
        if(node.ContainsKey(ch)){
            return true;
        }        
         return false;
    }
    public TrieNode GetNode(char ch){
        return node[ch];
    }
    public void put(char ch, TrieNode new_node){
        node[ch] = new_node;
    }    
}
public class Trie {
public readonly TrieNode root;
    public Trie() {
        root = new();
    }
    
    public void Insert(string word) {
      TrieNode node = root;
      for(int i = 0; i < word.Length; i++){
        if(!node.ContainsKey(word[i])){
            node.put(word[i],new TrieNode());
        }
        node = node.GetNode(word[i]);
      }  
      node.is_word = true;
    }
    
    public bool Search(string word) {
         TrieNode node = root;
          for(int i = 0; i < word.Length; i++){
        if(!node.ContainsKey(word[i])){
           return false;
        }
        node = node.GetNode(word[i]);
      }  
     return  node.is_word;
    }
    
    public bool StartsWith(string prefix) {
         TrieNode node = root;
          for(int i = 0; i < prefix.Length; i++){
        if(!node.ContainsKey(prefix[i])){
           return false;
        }
        node = node.GetNode(prefix[i]);
      }  
     return  true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */