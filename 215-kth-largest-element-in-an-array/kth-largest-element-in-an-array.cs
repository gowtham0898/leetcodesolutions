public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        k = nums.Length - k;
       int l = 0;
       int  r = nums.Length -1;

      return  QuickSearch(nums,l,r,k);

    }

    private int QuickSearch(int[] nums, int l, int r, int k){
       if( l ==  r){
        return nums[l];
       }
        int p = l;

        for(int i = l ; i < r; i++){
            if(nums[i] < nums[r]){
                (nums[i],nums[p]) = (nums[p],nums[i]);
                p++;
            }
       }
       (nums[p],nums[r]) = (nums[r],nums[p]);

        if(k < p){
           return QuickSearch(nums,l,p-1,k);
        }
        else if(k > p){
           return QuickSearch(nums,p+1,r,k);
        }
        else{
            return nums[k];
        }

    }
    //    PriorityQueue<int,int> min_heap = new();

    //    for(int i = 0; i < nums.Length; i++){
    //     min_heap.Enqueue(nums[i],nums[i]);
    //     if(min_heap.Count > k){
    //         min_heap.Dequeue();
    //     }
    //    } 

    //    return min_heap.Peek();
}