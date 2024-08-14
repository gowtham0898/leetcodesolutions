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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode dummyNode = new ListNode(-1);
        ListNode cur = dummyNode;
        int carry = 0;
        while(l1 != null || l2 != null){ // both should ne empty
            int sum = carry;
            if(l1 != null){
                sum += l1.val;
            }
            if(l2 != null){
                sum += l2.val;
            }
            // check remainder
            ListNode newNode = new ListNode(sum % 10); 
            //check carry
            carry = sum / 10;
            cur.next = newNode;
            cur = cur.next;
             if(l1 != null){
                l1 = l1.next;
            }
            if(l2 != null){
               l2 = l2.next;
            }
        }
        if(carry > 0){
             ListNode newNode = new ListNode(carry); 
              cur.next = newNode;
        }
        return dummyNode.next;
    }
}