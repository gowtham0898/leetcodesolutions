public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> has_set = new (nums);
        int seq = 0;
        for(int i = 0; i < nums.Length;i++){
            int num = nums[i];
            if(!has_set.Contains(num-1)){
                int cur_length = 0;
                while(has_set.Contains(num)){
                    cur_length++;
                    num++;
                }
                seq = Math.Max(seq,cur_length);
            }
        }
        return seq;
    }
}