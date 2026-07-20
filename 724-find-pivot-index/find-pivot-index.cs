public class Solution {
    public int PivotIndex(int[] nums) {
       int total_sum = nums.Sum();
       int left_sum = 0;
       for(int i = 0; i < nums.Length; i++){
        int right_sum = total_sum - left_sum - nums[i];
        if(right_sum == left_sum){
            return i;
        }

        left_sum += nums[i];
       } 
       return -1;
    }
}