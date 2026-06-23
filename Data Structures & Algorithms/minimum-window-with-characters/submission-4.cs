public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length)
            return "";

        Dictionary<char, int> charMap = new();

        foreach (char c in t) {
            if (!charMap.ContainsKey(c))
                charMap[c] = 0;

            charMap[c]++;
        }

        int l = 0;
        int start = -1;
        int minLen = int.MaxValue;
        int count = 0;

        for (int r = 0; r < s.Length; r++) {
            char c = s[r];

            if (charMap.ContainsKey(c)) {
                if (charMap[c] > 0)
                    count++;

                charMap[c]--;
            }

            while (count == t.Length) {
                if (r - l + 1 < minLen) {
                    minLen = r - l + 1;
                    start = l;
                }

                char left = s[l];

                if (charMap.ContainsKey(left)) {
                    charMap[left]++;

                    if (charMap[left] > 0)
                        count--;
                }

                l++;
            }
        }

        return start == -1 ? "" : s.Substring(start, minLen);
    }
}

/*
Common Pitfalls
Not Handling Duplicate Characters in Target
The target string t may contain duplicate characters (e.g., "AAB"). Simply checking for character presence is insufficient; you must track the exact count of each character and ensure the window contains at least that many occurrences.

Shrinking the Window Too Aggressively
When contracting the window from the left, some implementations remove characters before checking if the window is still valid. Always update the result before shrinking, and only shrink while the window remains valid.

Incorrect Validity Check Logic
Using have == need requires careful management: have should only increment when a character's count exactly reaches the required amount, and only decrement when it falls below. Incrementing have every time a required character is added leads to overcounting.

Forgetting to Handle Empty Target String
When t is empty, the minimum window is an empty string. Failing to handle this edge case at the start can lead to unexpected behavior or incorrect results.

Off-by-One Errors in Substring Extraction
When storing and returning the result window, confusing inclusive vs. exclusive bounds leads to returning a substring that is one character too short or too long. Ensure consistency between how you store indices and how you extract the final substring.
*/