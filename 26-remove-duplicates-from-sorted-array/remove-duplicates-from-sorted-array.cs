public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int l = 1; // l is our left pointer
        // our right pointer will increment always 
        for(int i = 1; i < nums.Length;i++){ // i is our right pointer
              // if you find any unique number then assign that to left pointer index and 
              // increment the left point
            if(nums[i] != nums[i-1])
            {
                nums[l] = nums[i];
                l++;
            }
            
        }
        return l;
    }
}