public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<string> sortedArray = new List<string>(strs);
        for(int i = 0; i < sortedArray.Count; i++){
            char[] sortedElm = sortedArray[i].ToCharArray();
            Array.Sort(sortedElm);
            sortedArray[i] = new String(sortedElm);
        }        

        Dictionary<string,List<string>> anagrams = new Dictionary<string,List<string>>();

        for(int i = 0; i < strs.Length; i++){
            if (anagrams.ContainsKey(sortedArray[i])){
                anagrams[sortedArray[i]].Add(strs[i]); 
            }
            else{
                anagrams[sortedArray[i]] = new List<string>(){strs[i]};
            }
        }

        List<List<string>> result = new List<List<string>>();
        
        foreach(var kvp in anagrams){
            result.Add(kvp.Value);
        }

        return result;
    }
}
