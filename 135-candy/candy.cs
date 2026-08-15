public class Solution {
    public int Candy(int[] rattings) {
        int[] cnd = new int[rattings.Length];
        Array.Fill(cnd,1);

        for(int i = 0 ; i < rattings.Length; i++){
            int prev_index = i -1;
            if(prev_index < 0) continue;
            if(rattings[i] > rattings[prev_index]){
                    cnd[i] = cnd[prev_index]+1;
            }
        }

         for(int j = rattings.Length -1; j >=0 ; j--){
            int prev_index = j +1;
            if(prev_index >= rattings.Length) continue;
            if(rattings[j] > rattings[prev_index]){
                    cnd[j] = Math.Max(cnd[j] , cnd[prev_index]+1);
            }
        }
      return cnd.Sum();  
    }
}