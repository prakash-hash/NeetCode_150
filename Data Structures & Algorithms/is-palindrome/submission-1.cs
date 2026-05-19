public class Solution {
    public bool IsAlphaNumeric(char c){
        if( (c >= 'A' && c <= 'Z') ||
            (c >= 'a' && c <= 'z') ||
            (c >= '0' && c <= '9' )
            ){
                return true;
            }
        return false;
    }
    public bool IsPalindrome(string s) {
        string lower = s.ToLower();
        int i = 0;
        int j = s.Length-1;
        while(i < j){
            if(!IsAlphaNumeric(lower[i])){
                i++; 
                continue;
            }
            if(!IsAlphaNumeric(lower[j])){
                j--; 
                continue;
            }
            if(lower[i++] != lower[j--]){
                return false;
            }
        }
        return true;
    }
}
