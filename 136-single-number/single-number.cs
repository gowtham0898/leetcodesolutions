public class Solution {
    public int SingleNumber(int[] nums) {
        int uniqueNumber = 0;
        foreach(int num in nums){
            //XOR operater return non duplicated number 
            //if  every element appears twice except
            uniqueNumber = uniqueNumber ^ num;
        }
        return uniqueNumber;
    }
}