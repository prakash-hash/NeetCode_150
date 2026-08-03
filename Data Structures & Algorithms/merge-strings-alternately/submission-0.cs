public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int l1 = word1.Length;
        int l2 = word2.Length;
        int i = 0;
        int j = 0;
        StringBuilder sb = new("");

        while(i < l1 || j < l2){
            if(i < l1){
                sb.Append(word1[i]);
            }

            if(j < l2){
                sb.Append(word2[j]);
            }

            i++;
            j++;
        }

        return sb.ToString();
    }
}