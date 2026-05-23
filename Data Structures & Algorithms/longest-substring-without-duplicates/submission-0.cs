public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int length = s.Length;
        if(length == 0){
            return 0;
        }
        else if(length == 1){
            return 1;
        }
        int result = 1;
        HashSet<char> charSet = new ();
        int l = 0;
        charSet.Add(s[l]);
        for(int r = 1; r < length; r++){
            while(charSet.Contains(s[r])){
                charSet.Remove(s[l]);
                l++;
            }
            charSet.Add(s[r]);
            result = Math.Max(result, r - l + 1);
        }

        return result;

    }
}
