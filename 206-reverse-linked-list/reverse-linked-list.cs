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

        ListNode newHead = ReverseList(head.next);

        ListNode front = head.next;
        front.next = head;
        head.next = null;
        return newHead;
    }
}