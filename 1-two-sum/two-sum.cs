public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        for(int i = 0; i < nums.Length ; i++){
            var _target = target - nums[i];

            if(nums.Contains(_target)){
                // using Array bcoz IndexOf function
                var _index = Array.IndexOf(nums,_target);
                 // should not be same index so 
                if(_index  != i)
                {
                    return new int[]{_index,i};
                }
            }   
        }
        // return an empty array, but size should be defined 
        return new int[0];
    }
}