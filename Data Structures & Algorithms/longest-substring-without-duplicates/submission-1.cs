public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> charMap = new();
        int length = s.Length;
        int l = 0;
        int r = 0;
        int max = 0;
        while(r < length){
            if(charMap.ContainsKey(s[r]) && charMap[s[r]] >= l){
                l = charMap[s[r]] + 1;
            }

            charMap[s[r]] = r;
            
            max = Math.Max(max, r - l + 1);
            r++;
        }

        return max;
    }
}
