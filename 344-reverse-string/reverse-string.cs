public class Solution {
    public void ReverseString(char[] s) {
        int l = 0;
        int n = s.Length -1;
         while(l < n){
            //  char temp = s[i]; // store in temp variable
            // s[i] = s[n]; // assign  to the last index
            // s[n] = temp; 
            s[l] ^= s[n];
            s[n] ^= s[l];
            s[l] ^= s[n];
            l++; n--;
         }
    }
}