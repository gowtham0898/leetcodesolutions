public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        int[] s1 = new int[26];
        for(int i = 0; i< s.Length ; i++){
            s1[s[i] - 'a']++;
        }
          for(int i = 0; i< t.Length ; i++){
            s1[t[i] - 'a']--;
        }

        foreach(var asci in s1){
            if(asci > 0){
                return false;
            }
        }

        return true;
    }
}