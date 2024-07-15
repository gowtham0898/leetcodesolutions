public class Solution {
    public bool Check(int[] nums) {
        int count = 0;
        for(var i =0; i < nums.Length;i++){
            //if array is sorted and rotated properly
            // then next number is always greater than previopus number and this is 
            //voilated only once in the array
            if(nums[i] > nums[(i+1)%nums.Length]){
                count++;
            }
        }
        if(count>1){
            return false;
        }
        return true;
    }
}