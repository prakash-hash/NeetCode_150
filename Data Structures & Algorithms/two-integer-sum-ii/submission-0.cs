public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length-1;

        while(i < j){
            int sum = numbers[i]+numbers[j];
            if(sum == target){
                return new int[2]{i+1, j+1};
            }
            if(sum < target){
                i++;
            }
            else{
                j--;
            }
        }

        return null;
    }
}
