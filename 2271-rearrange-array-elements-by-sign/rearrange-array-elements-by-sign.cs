public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int[] a = new int[nums.Length/2];
        int[] b = new int[nums.Length/2];
        int a1 = 0;
        int b1 = 0;
        for(int i = 0; i< nums.Length; i++){
            if(nums[i]>0){
                a[a1] = nums[i];
                a1++;
            }else{
                b[b1] =nums[i];
                b1++;
            }
        }

        for(int j = 0; j< (nums.Length / 2); j++){
            // this will if length is 6 but you want to 
            //itrate half times to fill all the 6 elements
         
            nums[j+j] = a[j];
            nums[j+j+1] = b[j];
        }

        return nums;
    }

    // time and space complacity = O(N)
}