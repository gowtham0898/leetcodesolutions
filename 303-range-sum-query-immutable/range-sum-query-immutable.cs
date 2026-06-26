public class NumArray {
    private readonly int[] input_array;

    public NumArray(int[] nums) {
       input_array =  nums;
    }
    
    public int SumRange(int left, int right) {
        int cur_sum = 0;
        while(left <= right){
            cur_sum += input_array[left];
            left++;
        }
        return cur_sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */