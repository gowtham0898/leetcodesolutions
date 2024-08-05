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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null ){
            return null;
        }

        int count = 0;
        ListNode current = head;
        while(current != null){
            current = current.next; 
            count++;
        }
        if(count ==1){
            return null;
        }
      int toDeleteNode = count - n;

      int currentCount = 1;
        if(toDeleteNode ==0){
            head = head.next;
        }
      ListNode temp = head;
      while(temp != null){
       
        if(currentCount == toDeleteNode){
            temp.next = temp.next.next;
        }
        temp = temp.next;
        currentCount++;
      }
      return head;
    }
}