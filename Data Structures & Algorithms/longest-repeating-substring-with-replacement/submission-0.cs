public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int>charSet = new Dictionary<char, int>();
        int result = 0;
        int l = 0;
        int r = 0;
        int maxChar = 0;
        while(r < s.Length){
            
            charSet[s[r]] = charSet.GetValueOrDefault(s[r], 0)+1;
            maxChar = Math.Max(maxChar, charSet[s[r]]);

            int length = r - l + 1;
            
            if(length - maxChar > k){
                charSet[s[l]]--;
                l++;
            }

            
            result = Math.Max(result, r - l + 1);
            r++;

        }
        return result;
    }
}
