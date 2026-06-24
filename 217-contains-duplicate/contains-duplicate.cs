public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> result = new();
        for(int i = 0; i < nums.Length; i++){
            if(result.Contains(nums[i])){
                return true;
            }

            result.Add(nums[i]);
        }
        return false;
    }
}