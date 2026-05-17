public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();
       foreach(string s in strs){
        int[] count = new int[26];
        foreach(char c in s){
            count[c - 'a']++;
        }
        string hashkey = string.Join(',', count);
        if(!res.ContainsKey(hashkey)){
            res[hashkey] = new List<string>();
        }
        res[hashkey].Add(s); 
       }
       return res.Values.ToList<List<string>>(); 
    }
}
