/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) {
            return null;
        }

        Dictionary<Node, Node> hashMap = new();
        Node curr = head;

        while(curr != null){
            hashMap[curr] = new Node(curr.val);
            curr = curr.next;
        }

        curr = head;

        while (curr != null) {
            hashMap[curr].next = curr.next == null ? null : hashMap[curr.next];
            hashMap[curr].random = curr.random == null ? null : hashMap[curr.random];
            curr = curr.next;
        }

        return hashMap[head];
    }
}
