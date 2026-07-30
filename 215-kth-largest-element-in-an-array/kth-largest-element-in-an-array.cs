public class Solution {
    public int FindKthLargest(int[] nums, int k) {
       PriorityQueue<int,int> min_heap = new();

       for(int i = 0; i < nums.Length; i++){
        min_heap.Enqueue(nums[i],nums[i]);
        while(min_heap.Count > k){
            min_heap.Dequeue();
        }
       } 

       return min_heap.Dequeue();
    }
}