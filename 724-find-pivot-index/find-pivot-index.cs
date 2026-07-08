public class Solution {
    public int PivotIndex(int[] nums) {
        int total = nums.Sum();
        int left_sum = 0;
        for(int i = 0; i < nums.Length; i++){
            int right_sum = total - nums[i]  - left_sum;
            if(left_sum == right_sum){
                return i;
            }
            left_sum += nums[i];
        }
        return -1;
    }
}