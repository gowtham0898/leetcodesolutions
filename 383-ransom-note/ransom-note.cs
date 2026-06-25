public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(ransomNote.Length > magazine.Length){
            return false;
        }
        int[] num = new int[26];

        for(int i =0; i<magazine.Length;i++){
            num[magazine[i] - 'a'] ++;
        }
        for(int i = 0; i<ransomNote.Length; i++){
             num[ransomNote[i] - 'a'] --;
             if(num[ransomNote[i] - 'a'] < 0){
                return false;
             }
        }
        return true;
        // Dictionary<char, int> map = new();

        // for(int i =0; i<magazine.Length;i++){
        //     if(map.ContainsKey(magazine[i])){
        //        map[magazine[i]]++;
        //     }
        //     else{
        //         map[magazine[i]] = 1;
        //     }
        // }   

        // for(int i = 0; i<ransomNote.Length; i++){
        //     if(map.ContainsKey(ransomNote[i])){
        //         map[ransomNote[i]]--;
        //         if(map[ransomNote[i]] == 0){
        //             map.Remove(ransomNote[i]);
        //         }                
        //     }
        //     else{
        //             return false;
        //         }
        // }
        // return true;
    }
}