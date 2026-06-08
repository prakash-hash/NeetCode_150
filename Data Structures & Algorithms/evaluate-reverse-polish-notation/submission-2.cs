public class Solution {

    public bool IsOperator(string op){
        return op == "+" || op == "-" || op == "*" || op == "/"; 
    }

    public int Calculate(int intA, int intB, string oprtr){

        switch(oprtr){
            case "+":
                return intA + intB;
            case "-":
                return intA - intB;
            case "*":
                return intA * intB;
            case "/":
                return intA / intB;        
        }

        return 0;
    }

    public int EvalRPN(string[] tokens) {
        int n = tokens.Length;
        
        if(n <= 2){
            return int.Parse(tokens[n - 1]);
        }

        Stack<int> st = new();

        for(int i = 0; i < n; i ++){
            if(IsOperator(tokens[i])){
                int b = st.Pop();  
                int a = st.Pop();  
                int c = Calculate(a, b, tokens[i]);
                st.Push(c);
            }else{
                st.Push(int.Parse(tokens[i]));
            }
        }

        return st.Peek();        
    }
}
