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
    public bool IsPalindrome(ListNode head) {
        
        ListNode temp = head;
        ListNode slow = temp;
        ListNode fast = temp;
        while(fast.next != null && fast.next.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode newHead = ReverseList(slow.next);
         // compare two head
         ListNode left = head;
         ListNode right = newHead;
         //boz right will reach to end
         while (right != null){
            if(left.val != right.val) return false;
            right = right.next;
            left = left.next;
         }
         ReverseList(newHead);
         return true;

    }
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