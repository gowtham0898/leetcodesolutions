public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        List<int>sub_set = new();
        BackTracking(0, nums,result,sub_set);

        return result;
    }

    private void BackTracking (int index, int[] nums,
    IList<IList<int>> result,  List<int>sub_set){
        // condetion
        if(index == nums.Length){
            result.Add(new List<int>(sub_set));
            return;
        }
        // take
        sub_set.Add(nums[index]);
        BackTracking(index + 1, nums, result, sub_set);

        sub_set.RemoveAt(sub_set.Count -1);
        BackTracking(index + 1, nums, result, sub_set);
    }
}

