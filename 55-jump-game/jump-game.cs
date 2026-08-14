public class Solution {
    public bool CanJump(int[] nums) {
        int max_index = 0;

        for(int i =0; i < nums.Length; i++){
            if(i > max_index) return false;
            max_index = Math.Max(max_index, i+nums[i]);
        }
        return true;
    }
}