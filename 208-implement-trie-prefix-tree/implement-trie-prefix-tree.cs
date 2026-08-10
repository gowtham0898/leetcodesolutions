public class TriNode{
    private readonly Dictionary<char,TriNode> child;
    private bool flag;
    public TriNode(){
        child = new();
        flag = false;
    }
   public bool ContainsKey(char ch){
         return child.ContainsKey(ch);
    }
   public void put(char ch, TriNode new_node){
        child[ch] = new_node;
    }
  public  TriNode get(char ch){
        return  child[ch];
    }
  public  void setflag(){
        flag = true;
    }
 public   bool getflag(){
        return flag;
    }
}
public class Trie {
    private readonly TriNode root;
    public Trie() {
        root = new TriNode();
    }
    
    public void Insert(string word) {
        TriNode curr_node = root;
         for(int i = 0; i< word.Length; i ++){
            if(!curr_node.ContainsKey(word[i])){
                curr_node.put(word[i],new TriNode());
            }
            curr_node = curr_node.get(word[i]);
         }
        curr_node.setflag();
    }
    
    public bool Search(string word) {
         TriNode curr_node  = root;
         for(int i = 0; i< word.Length; i ++){
            if(!curr_node.ContainsKey(word[i])){
                return false;
            }
            curr_node = curr_node.get(word[i]);
         }
         return curr_node.getflag();
    }
    
    public bool StartsWith(string prefix) {
         TriNode curr_node  = root;
         for(int i = 0; i< prefix.Length; i ++){
            if(!curr_node.ContainsKey(prefix[i])){
                return false;
            }
            curr_node = curr_node.get(prefix[i]);
         }
         return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */