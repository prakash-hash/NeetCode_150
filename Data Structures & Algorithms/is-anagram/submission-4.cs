public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, int> dict_S = new Dictionary<char, int>();
        Dictionary<char, int> dict_T = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {            
            dict_S[s[i]] = dict_S.GetValueOrDefault(s[i], 0) + 1;
            dict_T[t[i]] = dict_T.GetValueOrDefault(t[i], 0) + 1;
        }

        if(dict_S.Count != dict_T.Count){
            return false;
        }

        foreach(char key in dict_S.Keys){
            if(!dict_T.ContainsKey(key) || dict_S[key] != dict_T[key]){
                return false;
            }
        }

        return true;

    }
}

/*
Forgetting to Check Length First
If two strings have different lengths, they cannot be anagrams. Skipping this early check means wasting time processing strings that could never match. Always compare lengths first and return false immediately if they differ.

Case Sensitivity Issues
When the problem specifies lowercase letters only (as in this problem), case sensitivity is not an issue. However, if the problem allows mixed case, forgetting to normalize to the same case (e.g., converting both strings to lowercase) will cause incorrect results where "Listen" and "Silent" would wrongly be considered non-anagrams.
*/