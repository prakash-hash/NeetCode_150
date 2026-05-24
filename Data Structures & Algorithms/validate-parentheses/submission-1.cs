public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new();

        foreach (char c in s) {

            // Opening brackets
            if (c == '(' || c == '{' || c == '[') {
                stk.Push(c);
            }
            else {

                // No matching opening bracket
                if (stk.Count == 0) {
                    return false;
                }

                char top = stk.Pop();

                // Check matching pair
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '[')) {
                    return false;
                }
            }
        }

        // Stack should be empty if valid
        return stk.Count == 0;
    }
}