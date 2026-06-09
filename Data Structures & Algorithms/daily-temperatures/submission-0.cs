public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++){
            for(int j = i + 1; j < temperatures.Length; j++){
                if(temperatures[i] < temperatures[j]){
                    result[i] = j - i;
                    break;
                }
            }
        }

        return result;
    }
}
