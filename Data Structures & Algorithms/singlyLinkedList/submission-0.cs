public class LinkedList
{
    private class Node
    {
        public int Val;
        public Node Next;

        public Node(int val)
        {
            Val = val;
        }
    }

    private Node head;
    private Node tail;

    public LinkedList()
    {
        head = null;
        tail = null;
    }

    public int Get(int index)
    {
        Node current = head;

        while (current != null && index > 0)
        {
            current = current.Next;
            index--;
        }

        return current == null ? -1 : current.Val;
    }

    public void InsertHead(int val)
    {
        Node node = new Node(val);

        node.Next = head;
        head = node;

        if (tail == null)
            tail = node;
    }

    public void InsertTail(int val)
    {
        Node node = new Node(val);

        if (head == null)
        {
            head = tail = node;
            return;
        }

        tail.Next = node;
        tail = node;
    }

    public bool Remove(int index)
    {
        if (head == null)
            return false;

        // Remove head
        if (index == 0)
        {
            head = head.Next;

            if (head == null)
                tail = null;

            return true;
        }

        Node prev = head;

        while (prev != null && index > 1)
        {
            prev = prev.Next;
            index--;
        }

        if (prev == null || prev.Next == null)
            return false;

        if (prev.Next == tail)
            tail = prev;

        prev.Next = prev.Next.Next;

        return true;
    }

    public List<int> GetValues()
    {
        List<int> values = new List<int>();

        Node current = head;

        while (current != null)
        {
            values.Add(current.Val);
            current = current.Next;
        }

        return values;
    }
}