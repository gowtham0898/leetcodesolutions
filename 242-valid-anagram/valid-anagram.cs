public class Solution {
    public bool IsAnagram(string s, string t)
    {
     
     if (s.Length != t.Length)
     {
         return false;
     }
     List<char> source = new List<char>(s);
     List<char> target = new List<char>(t);
     for ( int i = 0; i < source.Count(); i++)
     {
         if (target.Contains(source[i]))
         {
             target.Remove(source[i]);
         }
     }
     if(target.Count != 0) 
     {
         return false;
     }
     return true;

    // this solution with  using sort
    //  var sorce = s.ToCharArray();
        // var target = t.ToCharArray();
    //    Array.Sort(sorce);
    //    Array.Sort(target);
    //    return sorce.SequenceEqual(target);
 }
}