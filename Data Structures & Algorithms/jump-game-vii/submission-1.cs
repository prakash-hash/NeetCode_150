public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {

        int n = s.Length;

        if(s[n-1] == '1'){
            return false;
        }

        bool?[] dp = new bool?[n];
        dp[n-1] = true;
        return DFS(0, minJump, maxJump, dp, s);
    }

    public bool DFS(int i, int minJump, int maxJump, bool?[] dp, string s){
        if(dp[i].HasValue){
            return dp[i].Value;
        }

        dp[i] = false;
        for(int j = i+minJump; j <= Math.Min(i+maxJump, s.Length-1); j++){
            if(s[j] == '0' && DFS(j, minJump, maxJump, dp, s)){
                dp[i] = true;
                break;
            }
        }

        return dp[i].Value;

    }
}