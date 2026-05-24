public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new();

        foreach(char c in s){
            if(c == '{' || c == '[' || c == '('){
                stk.Push(c);
            }
            else
            {
                // there were no opening brackets
                if(stk.Count == 0){
                    return false;
                }

                char top = stk.Pop();

                if( top == '{' && c != '}' ||
                    top == '[' && c != ']' ||
                    top == '(' && c != ')'
                    )
                {
                    return false;
                }
            }
        }

        return stk.Count == 0;
    }
}