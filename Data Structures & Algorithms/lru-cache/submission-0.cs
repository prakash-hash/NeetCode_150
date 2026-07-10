public class LRUCache
{
    class Node
    {
        public int Key;
        public int Value;

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    private readonly int capacity;
    private readonly Dictionary<int, LinkedListNode<Node>> map;
    private readonly LinkedList<Node> list;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        map = new Dictionary<int, LinkedListNode<Node>>();
        list = new LinkedList<Node>();
    }

    public int Get(int key)
    {
        if (!map.ContainsKey(key))
            return -1;

        var node = map[key];

        // Move to front (most recently used)
        list.Remove(node);
        list.AddFirst(node);

        return node.Value.Value;
    }

    public void Put(int key, int value)
    {
        if (map.ContainsKey(key))
        {
            var node = map[key];
            node.Value.Value = value;

            list.Remove(node);
            list.AddFirst(node);
            return;
        }

        if (map.Count == capacity)
        {
            var last = list.Last;
            map.Remove(last.Value.Key);
            list.RemoveLast();
        }

        var newNode = new LinkedListNode<Node>(new Node(key, value));
        list.AddFirst(newNode);
        map[key] = newNode;
    }
}