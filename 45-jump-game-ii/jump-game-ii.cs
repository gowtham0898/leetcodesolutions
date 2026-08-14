public class Solution {
    public int Jump(int[] nums) {       
        int max_index = 0;
        int min_jump  = 0;
        int cur_index = 0;
        if(nums.Length ==1){
            return 0;
        }
        for(int i = 0; i < nums.Length-1; i++){          
            max_index = Math.Max(max_index, i+nums[i]);
           if(i == cur_index){
                min_jump ++;
               cur_index =   max_index;
           }
        }
        return min_jump;
    }
}