public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        HashSet<int> unique = new HashSet<int>();
        foreach (var num in nums)
        {
            unique.Add(num);
        }
        int max_count = 0;
        foreach (var unique_ in unique)
        {

            if (!unique.Contains(unique_ - 1))
            {
                int count = 1;
                int x = unique_+1;
                while (unique.Contains(x))
                {
                    count++;
                    x++;
                }
                if (count > max_count)
                {
                    max_count = count;
                }
            }
        }
 return max_count;

    }
}