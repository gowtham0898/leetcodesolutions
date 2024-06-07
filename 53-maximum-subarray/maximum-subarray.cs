public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = int.MinValue;
        int curent_max = 0;
        for(int i = 0; i< nums.Length; i++){
            curent_max = curent_max + nums[i];
            // if(curent_max > max){
            //     max = curent_max;
            // }
            if(curent_max > max){
                max = curent_max;
            }
            if(curent_max < 0){
                curent_max = 0;
            }
        }

        return max;
    }
}