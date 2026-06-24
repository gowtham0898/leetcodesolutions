public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char,char> map1 = new();
        Dictionary<char,char> map2 = new();
        for(int i = 0; i< s.Length; i++){

            if(map1.ContainsKey(s[i])){
                if(map1[s[i]] != t[i]){
                    return false;
                }
            }
            map1[s[i]] = t[i];
            if(map2.ContainsKey(t[i])){
                if(map2[t[i]] != s[i]){
                    return false;
                }
            }
            map2[t[i]] = s[i];
        }
        return true;
    }
}