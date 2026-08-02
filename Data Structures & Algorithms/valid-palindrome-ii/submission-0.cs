public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while(left <= right){
            if(s[left] == s[right]){
                left++;
                right--;
            }
            else{
                return IsPlandrome(s, left + 1, right) ||
                       IsPlandrome(s, left, right - 1);
            }
            
        }

        return true;
    }

    public bool IsPlandrome(string s, int l, int r){

        while(l <= r){
            if(s[l] != s[r]){
                return false;
            }

            l++;
            r--;
        }

        return true;
    }
}