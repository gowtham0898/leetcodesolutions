public class Solution {
    public void MoveZeroes(int[] nums) {
        int l = 0;
        for(int r = 0; r < nums.Length; r++){
            if(nums[r] != 0){
                int temp = nums[l];
                nums[l] = nums[r];
                nums[r] = temp;
                l++;
            }
        }
    }
}