public class NumArray {
    private readonly int[] input_array;

    public NumArray(int[] nums) {
       input_array = new int[nums.Length]; 
       int cr_sum = 0;
       for(int i = 0; i< nums.Length; i++){
            cr_sum += nums[i];
            input_array[i] = cr_sum;
       }
    }
    
    public int SumRange(int left, int right) {
        if(left == 0){
            return input_array[right];
        }
        return input_array[right] - input_array[left -1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */