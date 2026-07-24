public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
            List<int> cur = new();

            findCombinations(0,candidates,target,result, cur);
            return result;
    }
    private void findCombinations(int i , int[] candidates,int target, IList<IList<int>> result, List<int> cur){
        if(i == candidates.Length){
            if(target ==0){
                result.Add(new List<int>(cur));
            }
            return;
        }  

        if(candidates[i] <= target){
            cur.Add(candidates[i]);
            findCombinations(i,candidates, target -candidates[i], result,cur );
            cur.RemoveAt(cur.Count -1);
        } 
        findCombinations(i +1,candidates, target, result,cur );
    }

}