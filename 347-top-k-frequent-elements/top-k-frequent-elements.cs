public class Solution {
   public int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> hashMap = new();

    foreach (int num in nums)
    {
        if (hashMap.ContainsKey(num))
            hashMap[num]++;
        else
            hashMap[num] = 1;
    }

    var result = hashMap
        .OrderByDescending(x => x.Value)
        .Take(k)
        .Select(x => x.Key)
        .ToArray();

    return result;
}
}