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

/*
#include <iostream>
#include <vector>
#include <string>
using namespace std;

bool isBalanced(string& s) {
    
    // stack top index in string
    int top = -1;
    for (int i = 0; i < s.length(); i++) {
        if (s[i] == '(' || s[i] == '{' || s[i] == '[') {
            
            // push opening bracket
            s[++top] = s[i]; 
        } 
        else if (s[i] == ')' || s[i] == '}' || s[i] == ']') {
            
            // no opening bracket
            if (top == -1) return false; 
            if ((s[i] == ')' && s[top] != '(') ||
                (s[i] == '}' && s[top] != '{') ||
                (s[i] == ']' && s[top] != '[')) {
                return false;
            }
            top--;
        }
    }
    
    // balanced if stack empty
    return top == -1; 
}

int main() {
      string s="[()()]{}";
      cout<<(isBalanced(s)?"true":"false");
}
*/