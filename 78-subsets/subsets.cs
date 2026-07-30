public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> cur = new();
       solve(nums, 0,result, cur);
       return result; 
    }

    private void solve(int[] nums, int index , IList<IList<int>> result, List<int> cur){
        if(index == nums.Length){
            result.Add(new List<int>(cur));
            return;
        }
        cur.Add(nums[index]);
        solve(nums, index+1,result, cur);
        cur.RemoveAt(cur.Count -1);
          solve(nums, index +1,result, cur);
    }
}