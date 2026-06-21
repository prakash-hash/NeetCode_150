public class Solution {
    public int[] PlusOne(int[] digits) {
        int len = digits.Length;
        if(digits[len - 1] < 9){
            digits[len - 1]++;
            return digits; 
        }

        int carry = 1;
        List<int> digitsRevers = new();
        for(int i = len - 1; i >= 0; i--){
            digitsRevers.Add((digits[i] + carry)%10);
            carry = (digits[i] + carry) <= 9 ? 0 : 1;
        }

        if(carry == 1){
            digitsRevers.Add(1);
        }

        digitsRevers.Reverse();

        return digitsRevers.ToArray();
    }
}
