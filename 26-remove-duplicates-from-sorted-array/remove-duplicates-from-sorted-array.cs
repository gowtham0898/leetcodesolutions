public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> hash = new();
        int l = 0;
        for(int i = 0; i < nums.Length; i++){
           if(hash.Add(nums[i])){
               nums[l] = nums[i];
               l++;
           }
        }
        for(int j = hash.Count; j < nums.Length; j++){
            nums[j] = 0;
        }
        return hash.Count;
    }
}