public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> sums = new();
        int currSum = 0; 
        while(currSum != 1){
            currSum = 0;

            while(n > 0){
                int digit = n%10;
                currSum += digit*digit;
                n = n/10; 
            }

            if(sums.Contains(currSum)){
                return false;
            }
            n = currSum;
            sums.Add(currSum);
        }

        return true;
    }
}
