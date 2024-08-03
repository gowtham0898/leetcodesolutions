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
        ListNode current = head;
        ListNode past = null;
        while(current != null){
            ListNode front = current.next;
            current.next = past;
            past = current;
            current = front;
        }
        return past;
    }
}