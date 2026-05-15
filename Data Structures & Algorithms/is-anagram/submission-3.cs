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

        foreach(char key in dict_S.Keys){
            if(!dict_T.ContainsKey(key) || dict_S[key] != dict_T[key]){
                return false;
            }
        }

        return true;

    }
}
