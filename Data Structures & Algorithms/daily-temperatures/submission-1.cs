public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<int> st = new();
        st.Push(0);
        for(int i = 1; i < temperatures.Length; i++){
            while(st.Count > 0 && temperatures[i] > temperatures[st.Peek()]){
                result[st.Peek()] = i - st.Peek();
                st.Pop();
            }
            st.Push(i);
        }

        return result;
    }
}
