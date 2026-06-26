public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0;
        int cr_sum = 0;
        Dictionary<int,int> map = new();
        map[0] = 1;

        for(int i = 0; i< nums.Length; i++){
            cr_sum += nums[i];
            int pre_sum = cr_sum - k;
            if(map.ContainsKey(pre_sum)){
                result += map[pre_sum];                
            }

            if(map.ContainsKey(cr_sum)){
                map[cr_sum]++;
            }
            else{
                map[cr_sum] = 1;
            }   
        }
        return result; 
    }
}