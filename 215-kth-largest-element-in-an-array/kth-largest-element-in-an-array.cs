public class Solution {
    public int FindKthLargest(int[] nums, int k) {       
       k = nums.Length -k;

        return QuickSelect(nums, 0, nums.Length -1, k);
    }
    private int QuickSelect(int[] nums, int l,int r,int k){
        if(l == r){
            return nums[l];
        }
        int pivot = nums[r];
        int p = l;
        for(int i = l; i < r; i++){
            if(pivot > nums[i]){
                (nums[p], nums[i]) = (nums[i], nums[p]);
                p++;
            }
        }
        (nums[p], nums[r]) = (nums[r], nums[p]);       
        if(p > k){
           return QuickSelect(nums, l,p-1, k);
        }
        else if(p < k){
           return QuickSelect(nums, p +1, r, k);
        }
        else{
            return nums[p];
        }
    }
}