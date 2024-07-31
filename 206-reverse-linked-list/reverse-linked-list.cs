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
    public ListNode ReverseList(ListNode head) {
     if(head == null || head.next == null){
        return head;
     }   

     ListNode temp = head;
     ListNode previous = null;
     while(temp != null){
        ListNode future = temp.next;
        temp.next = previous;
        previous = temp;
        temp = future;
     }
     return previous;
    }
}