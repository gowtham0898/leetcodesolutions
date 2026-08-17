public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> map = new();
        foreach(char mag in magazine){
            if(!map.ContainsKey(mag)){
              map[mag] = 0;      
            }
            map[mag]++;
        }

        foreach(char rn in ransomNote){
            if(!map.ContainsKey(rn)) return false;

            map[rn]--;
            if(map[rn] == 0){
                map.Remove(rn);
            }
        }
        return true;
    }
}