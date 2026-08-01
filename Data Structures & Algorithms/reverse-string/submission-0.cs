public class Solution {
    public void ReverseString(char[] s) {
        int len = s.Length;
        for(int i = 0; i < len/2; i++){
            int j = len - 1 - i;
            char t = s[i];
            s[i] = s[j];
            s[j] = t;
        }
    }
}