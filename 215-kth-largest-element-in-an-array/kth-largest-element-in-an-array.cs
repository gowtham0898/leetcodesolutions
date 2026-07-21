public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> min_heamp = new();
        for(int i = 0; i < nums.Length; i++){
            min_heamp.Enqueue(nums[i],nums[i]);

            if(min_heamp.Count > k){
                min_heamp.Dequeue();
            }
        }

        return min_heamp.Dequeue();
     }
    //   public int FindKthLargest(int[] nums, int k) { 
    //    PriorityQueue<int,int> max_heap = new();
    //    for(int i = 0; i < nums.Length; i++){
    //          max_heap.Enqueue(nums[i], -nums[i]);
    //    }
    //   int res = 0;
    //   while(k > 0){
    //     res = max_heap.Dequeue();
    //     k--;
    //   }
    //   return res;
    // }

    // public int FindKthLargest(int[] nums, int k) { 
    //     k = nums.Length - k;

    //     return QuickSelect(nums, 0, nums.Length - 1, k);
    // }

    // private int QuickSelect(int[] nums, int left, int right, int result_index){
    //     int _base = nums[right];
    //     int partition = left;
    //     for(int i = left; i < right; i++){
    //         if(_base > nums[i]){
    //             (nums[partition],nums[i]) = (nums[i],nums[partition]);
    //             partition ++; 
    //         }           
    //     }
    //      (nums[partition],nums[right]) = (nums[right],nums[partition]);

    //     if(partition > result_index){
    //         return QuickSelect(nums,left, partition-1, result_index);
    //     }
    //     else if(partition < result_index){
    //         return QuickSelect(nums,partition+1, right, result_index);
    //     }
    //     else{
    //         return nums[partition];
    //     }

    // }
}




















    // private int QuickSelect(int[] nums, int l,int r,int k){
    //     if(l == r){
    //         return nums[l];
    //     }
    //     int pivot = nums[r];
    //     int p = l;
    //     for(int i = l; i < r; i++){
    //         if(pivot > nums[i]){
    //             (nums[p], nums[i]) = (nums[i], nums[p]);
    //             p++;
    //         }
    //     }
    //     (nums[p], nums[r]) = (nums[r], nums[p]);       
    //     if(p > k){
    //        return QuickSelect(nums, l,p-1, k);
    //     }
    //     else if(p < k){
    //        return QuickSelect(nums, p +1, r, k);
    //     }
    //     else{
    //         return nums[p];
    //     }
    // }