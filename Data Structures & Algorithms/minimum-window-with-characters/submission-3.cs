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