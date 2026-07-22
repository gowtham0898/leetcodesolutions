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
        if(lists == null || lists.Length ==0){
            return null;
        }
        return Merge(lists, 0, lists.Length -1);   
      }
      private ListNode Merge(ListNode[] lists, int left, int right){
        if(left == right){
            return lists[left];
        }
        int m = left + (right - left)/2;
        ListNode l1 = Merge(lists, left, m);
        ListNode l2 = Merge(lists, m+1, right);

        return MergeTwoList( l1,  l2);
      }
      private ListNode MergeTwoList(ListNode l1, ListNode l2){
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while( l1 != null && l2 != null){
            if(l1.val < l2.val ){
            tail.next = l1;
            tail = tail.next;
            l1 = l1.next;
            }
            else{
                tail.next = l2;
                tail = tail.next;
                l2 = l2.next;
            }
        }
            tail.next = l1 ?? l2;
        return dummy.next;
      }
    // public ListNode MergeKLists(ListNode[] lists) {
    //     PriorityQueue<ListNode,int> heap = new();

    //     foreach(var list in lists){
    //         if(list != null){
    //             heap.Enqueue(list,list.val);
    //         }
    //     }
    //     ListNode dummy = new ListNode(0);
    //     ListNode tail = dummy;
    //     while(heap.Count > 0){
    //         ListNode smallest = heap.Dequeue();
    //         tail.next = smallest;
    //         tail = tail.next;
    //         if(smallest.next != null){
    //             heap.Enqueue(smallest.next, smallest.next.val);
    //         }
    //     }
    //     return dummy.next;
    // }
}