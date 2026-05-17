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

/*
Time & Space Complexity
Time complexity: 
O(m∗n)
Space complexity:

O(m) auxiliary space, excluding the returned output.

O(m∗n) total space if the output groups are counted.

Where 
m is the number of strings and 
n is the length of the longest string.

Common Pitfalls
Using a Mutable Key Type for the Hash Map
When using character frequency arrays as keys, you must convert them to an immutable type (like a tuple in Python or a string in other languages). Lists and arrays are mutable and cannot be used as dictionary keys directly.

# Wrong: using list as key
count = [0] * 26
res[count].append(s)  # TypeError: unhashable type 'list'

# Correct: convert to tuple
res[tuple(count)].append(s)
Assuming Input Contains Only Lowercase Letters
The frequency array approach with size 26 only works for lowercase English letters. If the input could contain uppercase letters or other characters, the solution would fail or produce incorrect groupings.

# Wrong: will crash on uppercase
count[ord(c) - ord('a')] += 1  # Negative index for uppercase

# Should validate or handle: ord('A') - ord('a') = -32
Creating a New Key Format That Has Collisions
When converting frequency counts to strings, using a naive format like concatenation without separators can cause collisions. For example, counts [1,11] and [11,1] could produce the same string "111".

# Wrong: potential collisions
key = ''.join(str(c) for c in count)  # "111" for both [1,11] and [11,1]

# Correct: use separator
key = ','.join(str(c) for c in count)  # "1,11" vs "11,1"
*/