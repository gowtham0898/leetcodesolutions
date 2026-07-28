public class NumArray {
    private readonly int[] prefix_sum;
    public NumArray(int[] nums) {
        prefix_sum = new int[nums.Length];
        int cur_sum = 0;
        for(int i = 0; i < nums.Length; i++){
            cur_sum += nums[i];
            prefix_sum[i] = cur_sum;
        } 
    }
    
    public int SumRange(int left, int right) {
          if(left ==0){
            return prefix_sum[right];
          }  

          return prefix_sum[right] - prefix_sum[left-1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */