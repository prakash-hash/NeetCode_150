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

/*
Common Pitfalls
Wrong Operand Order for Subtraction and Division
For subtraction and division, the order matters: the second-to-last operand is the left operand, and the last operand is the right operand. When you pop from a stack, the first pop gives you the right operand (b), and the second pop gives you the left operand (a). Computing b - a or b / a instead of a - b or a / b will produce incorrect results.

Incorrect Integer Division Truncation
Division in RPN truncates toward zero, not toward negative infinity. In languages like Python 2 or when using floor division, -7 / 2 gives -4, but the correct RPN result is -3. You must use truncation toward zero, such as int(a / b) in Python 3 or Math.trunc() in JavaScript.

Treating Negative Numbers as Operators
Tokens like "-3" are valid negative numbers, not the subtraction operator followed by "3". When checking if a token is an operator, you cannot simply check if the first character is -. Instead, check if the token equals exactly "+", "-", "*", or "/", or verify that the token has length 1 when it starts with an operator character.
*/