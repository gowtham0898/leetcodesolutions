public class NumArray {
    private readonly int[] pre_nums;
    public NumArray(int[] nums) {
        pre_nums = new int[nums.Length];
        int pre_sum = 0;
        for(int i = 0 ; i < nums.Length ; i++){
            pre_sum  += nums[i];
            pre_nums[i] = pre_sum;
        }
        
    }
    
    public int SumRange(int left, int right) {
        if(left == 0){
            return pre_nums[right];
        }
        return pre_nums[right] - pre_nums[left - 1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */