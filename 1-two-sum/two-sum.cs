public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> result = new List<int>();

for(int i = 0;i < nums.Length;i++)
{

    var _target = target - nums[i];
    if (result.Contains(_target))
    {
        var contains = result.IndexOf(_target);
         return new int[] {i, contains};
    }
    result.Add(nums[i]);
}



return new int[0];
    }
}