public class NumArray {
    private readonly int[] res_nums;
    public NumArray(int[] nums) {   
        res_nums = new int[nums.Length];     
        for(int i = 0; i < nums.Length; i++){
            if(i == 0){
                res_nums[0] = nums[0];
                continue;
            }
            res_nums[i] = res_nums[i-1] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        if(left == 0){
            return res_nums[right];
        }

        return res_nums[right]  - res_nums[left - 1] ;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */