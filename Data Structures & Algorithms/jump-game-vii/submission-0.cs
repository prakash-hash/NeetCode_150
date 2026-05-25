public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {

        int n = s.Length;

        bool[] dp = new bool[n];
        dp[0] = true;

        int reachable = 0;

        for (int i = 1; i < n; i++) {

            // add new index entering window
            if (i >= minJump && dp[i - minJump]) {
                reachable++;
            }

            // remove old index leaving window
            if (i > maxJump && dp[i - maxJump - 1]) {
                reachable--;
            }

            // current position reachable?
            if (reachable > 0 && s[i] == '0') {
                dp[i] = true;
            }
        }

        return dp[n - 1];
    }
}