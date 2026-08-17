public class Solution {
    public int SubarraySum(int[] nums, int k) {
       Dictionary<int,int> map = new();
       map[0] = 1;
       int cur = 0;
       int res = 0;
       for(int i = 0; i < nums.Length; i++){
        cur += nums[i];
        int pre_sum = cur - k;
        if(map.ContainsKey(pre_sum)){
            res+=map[pre_sum];
        }
       if(map.ContainsKey(cur)){
        map[cur]++;
       }else{
             map[cur] = 1;
       }
       }
       return res;
    }
}