public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        for(int i = 0; i < nums.Length ; i++){
            var _target = target - nums[i];
            if(nums.Contains(_target)){
                var _index = Array.IndexOf(nums,_target);
                if(_index  != i)
                {
                    return new int[]{_index,i};
             }
                }
                
        }
        return new int[0];
    }
}