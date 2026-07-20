public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        Dictionary<int, int> map = new();
        map[0] = -1;
        int pre_sum = 0;
        for(int i =0; i< nums.Length; i++){
            pre_sum += nums[i];
            int rem = pre_sum % k;
            if(map.ContainsKey(rem)){
                if(i - map[rem] > 1){
                    return true;
                }
            }
            else{
                map[rem] = i;
            }
        }
        return false;
    }
}