public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count =0;
        int max_count = 0;
        for(int i = 0; i< nums.Length ; i++){

            if(nums[i] == 1){
                count++;
            }
            else{
                count = 0;
            }
            if(count> max_count){
                max_count = count;
            }
        }
        return max_count;
    }
}