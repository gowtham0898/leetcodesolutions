public class Solution {
    public int[] RunningSum(int[] nums) {
        int pre_sum = 0;
        for(int i =0 ; i < nums.Length; i++){
            pre_sum += nums[i];
            nums[i] = pre_sum;
        }
        return nums;
    }
}