public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> max_count = new Dictionary<int,int> ();

        for(int i = 0; i < nums.Length;i++){

            if(max_count.ContainsKey(nums[i])){
                max_count[nums[i]]++;
            }
            else{
                max_count.Add(nums[i],1);
            }
        }
        int maxCount = 0;
        int max_valu = 0;
        foreach(var elements in max_count){
            if(elements.Value > maxCount){
                max_valu = elements.Key;
                maxCount = elements.Value;
            }
        }

        return max_valu;
    }
}