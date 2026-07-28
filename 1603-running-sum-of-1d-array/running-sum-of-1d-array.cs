public class Solution {
    public int[] RunningSum(int[] nums) {
        int cur = 0;
        int l = nums.Length;
        int i = 0;
        while(i < l){
            cur += nums[i];
            nums[i] = cur;
            i++;
        }
        return nums;
    }
    //   int pre_sum = 0;
    //     for(int i =0 ; i < nums.Length; i++){
    //         pre_sum += nums[i];
    //         nums[i] = pre_sum;
    //     }
    //     return nums;
}