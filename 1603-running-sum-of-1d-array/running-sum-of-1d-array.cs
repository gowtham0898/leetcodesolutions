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
}