public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string,List<string>> map = new();
        for(int i = 0; i< strs.Length; i++){
            int[] asci = new int[26];
            foreach(var ch in strs[i]){
                asci[ch - 'a']++;
            }
            var s_key = string.Join(',',asci);

            if(map.ContainsKey(s_key)){
                map[s_key].Add(strs[i]);
            } 
            else{
                map[s_key] = new List<string>{strs[i]};
            }
        }
        return map.Values.ToList<IList<string>>();
    }
}