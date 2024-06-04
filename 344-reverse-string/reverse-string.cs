public class Solution {
    public void ReverseString(char[] s) {
        int i = 0;
        int n = s.Length -1 ;

      while(i < n){
        char temp = s[i]; // store in temp variable
        s[i] = s[n]; // assign  to the last index
        s[n] = temp; 
        i ++ ; n--;
      }
    }
}