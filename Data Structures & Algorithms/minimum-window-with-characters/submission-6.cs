public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> charMap = new();
        
        foreach(char c in t){
            if(!charMap.ContainsKey(c)){
                charMap[c] = 0;
            }
            charMap[c]++;
        }

        int minLength = int.MaxValue;
        int startIndex = -1;
        int count = 0;
        int l = 0;
        int r = 0;
        
        while(r < s.Length){
            if(charMap.ContainsKey(s[r])){
                if(charMap[s[r]] > 0){
                    count++;
                }

                charMap[s[r]]--;
            }

            while(count == t.Length){
                
                if(r - l + 1 < minLength){
                    startIndex = l;
                    minLength = r - l + 1;
                }

                if(charMap.ContainsKey(s[l])){
                    charMap[s[l]]++;

                    if(charMap[s[l]] > 0){
                        count--;
                    }
                }

                l++;
            }

            r++;
        }

        return startIndex == -1 ? "" : s.Substring(startIndex, minLength);
    }
}
