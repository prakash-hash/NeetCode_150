public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        int[] count = new int[26];
        for(int i = 0; i < s.Length; i++){
            // char - 'a' will give us a number. subtracting with a gives us a range of 0-25
            count[s[i] - 'a']++;
            count[t[i] - 'a']--; // subtracting the numbers if it have same freq then it will give 0
        }

        foreach(int i in count){
            if(i != 0){
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