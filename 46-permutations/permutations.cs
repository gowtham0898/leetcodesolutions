public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
         List<int> cur = new();

    Solve(nums, result,cur);
    return result;
    }
    private void Solve(int[] nums, IList<IList<int>> result, List<int> cur){

        if(cur.Count == nums.Length){
            result.Add(new List<int>(cur));
            return;
        }
        foreach(var num in nums){
            if(cur.Contains(num)){
                continue;
            }
            cur.Add(num);
            Solve(nums, result,cur);
            cur.RemoveAt(cur.Count -1);
        }
    }
}