public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
     IList<IList<int>> result = new List<IList<int>>();
     List<int> current = new();
      List<int> used = new();
         Backtrack(result,nums, current, used); 
         return result;
    }

    private void Backtrack( IList<IList<int>> result, int[] nums, List<int> current, List<int> used){
        
        if(current.Count == nums.Length){
            result.Add(new List<int>(current));
            return;
        }

        foreach(int num in nums){

         if(current.Contains(num)){
            continue;
         }  
         current.Add(num);
         used.Add(num);
         Backtrack(result,nums, current, used); 
          current.RemoveAt(current.Count - 1);
        used.Remove(num);
        }
    }
}