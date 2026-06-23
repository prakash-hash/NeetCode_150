public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length < t.Length){
            return "";
        }

        Dictionary<char, int> charMap = new();
        foreach(char c in t){
            if(!charMap.ContainsKey(c)){
                charMap[c] = 0;
            }

            charMap[c]++;
        }

        int startIndex = -1;
        int l = 0;
        int r = 0;
        int minLength = int.MaxValue;
        int count = 0;
        while(r < s.Length){
            if(charMap.ContainsKey(s[r]) ){
                if(charMap[s[r]] > 0)
                    {
                        count++;
                    }
                    
                charMap[s[r]]--;
            }

            while(count == t.Length){
                if(minLength > r - l + 1){
                    minLength = r - l + 1;
                    startIndex = l;
                }

                if(charMap.ContainsKey(s[l])){
                    charMap[s[l]]++;
                    count = charMap[s[l]] > 0 ? --count : count; 
                }

                l++;
            }

            r++;
        }

        return startIndex == -1 ? "" : s.Substring(startIndex, minLength);
    }
}
