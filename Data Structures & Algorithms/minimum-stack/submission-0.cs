public class MinStack {
    List<int> stack;
    List<int> minStack;
    public MinStack() {
        stack = new();
        minStack = new();
    }
    
    public void Push(int val) {
        stack.Add(val);
        int count = minStack.Count;
        if(count == 0){
            minStack.Add(val);
        }
        else{
            minStack.Add(Math.Min(val, minStack[count - 1]));
        }
    }
    
    public void Pop() {
        stack.RemoveAt(stack.Count - 1);
        minStack.RemoveAt(minStack.Count - 1);
    }
    
    public int Top() {
        int i = stack.Count - 1;
        int top = stack[i];
        return top;
    }
    
    public int GetMin() {
        int i = minStack.Count - 1;
        return minStack[i];
    }
}
