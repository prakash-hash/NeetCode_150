public class MyQueue
{
    private Stack<int> input = new();
    private Stack<int> output = new();

    public MyQueue()
    {
    }

    public void Push(int x)
    {
        input.Push(x);
    }

    public int Pop()
    {
        MoveElements();
        return output.Pop();
    }

    public int Peek()
    {
        MoveElements();
        return output.Peek();
    }

    public bool Empty()
    {
        return input.Count == 0 && output.Count == 0;
    }

    private void MoveElements()
    {
        if (output.Count == 0)
        {
            while (input.Count > 0)
            {
                output.Push(input.Pop());
            }
        }
    }
}


/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */