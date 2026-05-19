public class Solution {
    public bool IsAlphaNumeric(char c){
        int asciiValue = (int)c;
        if( (asciiValue >= 48 && asciiValue <= 57) ||
            (asciiValue >= 65 && asciiValue <= 90) ||
            (asciiValue >= 97 && asciiValue <= 122 )
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
            if(lower[i] == ' ' || !IsAlphaNumeric(lower[i])){
                i++; 
                continue;
            }
            if(lower[j] == ' ' || !IsAlphaNumeric(lower[j])){
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
