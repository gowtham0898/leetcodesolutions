public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        Dictionary<int,int> result = new();
        result[0] = -1;
        int pre_sum = 0;
        for(int i = 0; i < nums.Length; i++){
            pre_sum += nums[i];

            int mod = pre_sum % k;
            if(result.ContainsKey(mod)){
                if(i - result[mod] > 1){
                    return true;
                }
            }else{
                 result[mod] = i;
            }
           
        }
        return false;
    }
}