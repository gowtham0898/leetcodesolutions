public class Solution {
    public int FindMaxLength(int[] nums) {
        int one = 0;
        int zero = 0;
        Dictionary<int, int> map = new();
        map[0] = -1;
        int result = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                zero += 1;
            }
            else{
                one +=1;
            }
            int dif = one - zero;
            if(map.ContainsKey(dif)){
                int dif_idx = map[dif];
               result =  Math.Max(result, i - dif_idx);
            }
            else{
                 map[dif] = i;
            }                              
        } 
        return result;
    }
}