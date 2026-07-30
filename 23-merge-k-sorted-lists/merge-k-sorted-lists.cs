/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> min_list = new();
        foreach(var list in lists){
            if(list != null){
                min_list.Enqueue(list,list.val);
            }
            
        }
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;
        while(min_list.Count > 0){
           var min_node = min_list.Dequeue();
           tail.next = min_node;
           tail = tail.next;
           if(min_node.next != null){
            min_list.Enqueue(min_node.next, min_node.next.val);
           }
        }
        return dummy.next;
    }
}