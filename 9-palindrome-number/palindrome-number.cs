public class Solution {
    public bool IsPalindrome(int x) {
        var string_number = x.ToString();

         char [] chars = string_number.ToCharArray();
        // Array.Reverse(chars);
        // var reverese_char = new string(chars);
        // if(string_number == reverese_char)
        // {
        //     return true;
        // }
        // return false;

        int mid = 0;
        int last= chars.Length -1 ;
        while (mid < last){
            if(chars[mid] != chars[last]){
                return false;
            }
            mid++;last--;
        }
        return true;
    }
}