/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null) return node;
        Dictionary<Node,Node> old_new = new();
        return DFS(node, old_new);
    }
    private Node DFS(Node node, Dictionary<Node,Node> old_new){
        if(old_new.ContainsKey(node)){
            return old_new[node];
        }
        Node copy = new Node(node.val);
        old_new[node] = copy;
        foreach(var nei in node.neighbors){
            copy.neighbors.Add(DFS(nei, old_new));            
        }

        return copy;
    }
}