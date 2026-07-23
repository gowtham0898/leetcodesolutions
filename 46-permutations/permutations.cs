public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
     IList<IList<int>> result = new List<IList<int>>();
     List<int> current = new();
         Backtrack(result,nums, current); 
         return result;
    }

    private void Backtrack( IList<IList<int>> result, int[] nums, List<int> current){
        
        if(current.Count == nums.Length){
            result.Add(new List<int>(current));
            return;
        }

        foreach(int num in nums){

         if(current.Contains(num)){
            continue;
         }  
         current.Add(num);
         Backtrack(result,nums, current); 
          current.RemoveAt(current.Count - 1);
        }
    }
}