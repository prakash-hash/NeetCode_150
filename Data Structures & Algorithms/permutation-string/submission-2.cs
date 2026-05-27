public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char, int> charSetS1 = new();
        Dictionary<char, int> charSetS2 = new();
        int matches = 0;
        int lengthS1 = s1.Length;
        int lengthS2 = s2.Length;

        if(lengthS1 > lengthS2)
        {
            return false;
        }

        for(char c = 'a'; c <= 'z'; c++){
            charSetS1[c] = 0;
            charSetS2[c] = 0;
        }

        for(int i = 0; i < s1.Length; i++){
            charSetS1[s1[i]]++;
            charSetS2[s2[i]]++;
        }

        for(char c = 'a'; c <= 'z'; c++){
            if(charSetS2[c] == charSetS1[c]){
                matches++;
            }
        }

        if(matches == 26){
            return true;
        }
        else if(lengthS1 == lengthS2){
            return false;
        }

        int l = 0;
        int r = lengthS1;
        while(r < lengthS2){
            charSetS2[s2[r]]++;
            if(charSetS2[s2[r]] == charSetS1[s2[r]]){
                matches++;
            }
            else if(charSetS2[s2[r]] == charSetS1[s2[r]] + 1){
                matches--;
            }

            charSetS2[s2[l]]--;
            if(charSetS2[s2[l]] == charSetS1[s2[l]]){
                matches++;
            }
            else if(charSetS2[s2[l]] == charSetS1[s2[l]] - 1){
                matches--;
            }

            if(matches == 26){
                return true;
            }

            l++;
            r++;
        }

        return false; 
    }
}
