public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int [] res = new int[nums.Length];
        int pre_fix = 1;
        for(int i = 0; i < nums.Length; i++){
            res[i] = pre_fix;
            pre_fix *= nums[i];
        }

        int post_fix = 1;
        for(int j = nums.Length - 1; j >= 0; j--){
            res[j] = post_fix * res[j];
            post_fix *= nums[j];
        }

        return res;
    }
}