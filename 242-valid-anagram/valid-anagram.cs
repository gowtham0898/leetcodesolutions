public class Solution {
    public bool IsAnagram(string s, string t) {
        
        var sorce = s.ToCharArray();
        var target = t.ToCharArray();
       Array.Sort(sorce);
       Array.Sort(target);
       return sorce.SequenceEqual(target);
    }
}