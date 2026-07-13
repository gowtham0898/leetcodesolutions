public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
      int pre_sum = 0;
      Dictionary<int,int> map = new();
      map[0] = -1;
      for(int i = 0; i < nums.Length; i++){
        pre_sum += nums[i];
        int rem = pre_sum % k;
        if(!map.ContainsKey(rem)){
            map[rem] = i;
        }
        else if(i - map[rem] > 1){
            return true;
        }
      } 
      return false; 
    }
}