public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
         IList<IList<int>> result = new List<IList<int>>();
         List<int> cur = new();
        Solve(candidates,target,0,result,cur);
        return result;
    }
    private void Solve(int[] candidates,int target,int index,IList<IList<int>> result,List<int> cur){
        if(index == candidates.Length){
            if(target ==0){
                result.Add(new List<int>(cur));
            }
            return;
        }

        if(candidates[index] <= target){
            cur.Add(candidates[index]);
            Solve(candidates,target-candidates[index],index,result,cur);
            cur.RemoveAt(cur.Count -1);
        }
         Solve(candidates,target,index+1,result,cur);
    }
}