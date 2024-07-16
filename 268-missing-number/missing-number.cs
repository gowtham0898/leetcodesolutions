public class Solution {
    public int MissingNumber(int[] nums) {
        int missing = 0;

        for(int i =0; i <= nums.Length; i++)
        {
            if(!nums.Contains(i))
            {
                missing = i; 
            }
        }
        return missing;
    }
}