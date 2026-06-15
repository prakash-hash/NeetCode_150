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
        if (head == null)
            return null;

        // 1. Insert copied nodes
        Node curr = head;
        while (curr != null) {
            Node copy = new Node(curr.val);
            copy.next = curr.next;
            curr.next = copy;
            curr = copy.next;
        }

        // 2. Assign random pointers
        curr = head;
        while (curr != null) {
            if (curr.random != null) {
                curr.next.random = curr.random.next;
            }

            curr = curr.next.next;
        }

        // 3. Separate lists
        curr = head;
        Node copyHead = head.next;

        while (curr != null) {
            Node copy = curr.next;

            curr.next = copy.next;

            if (copy.next != null) {
                copy.next = copy.next.next;
            }

            curr = curr.next;
        }

        return copyHead;
    }
}

/*
Common Pitfalls
Creating Multiple Copies of the Same Node
Without a hash map to track already-copied nodes, you might create duplicate copies when multiple random pointers point to the same node. Always check if a node has been copied before creating a new copy.

# Wrong - creates duplicates
copy.random = Node(original.random.val)

# Correct - use hash map to reuse existing copy
copy.random = oldToCopy[original.random]
Forgetting to Handle Null Random Pointers
The random pointer can be null. Attempting to access properties of null causes crashes. Always check for null before dereferencing.

# Wrong - crashes if random is None
copy.random = oldToCopy[original.random]  # KeyError if random is None

# Correct - handle None explicitly
oldToCopy[None] = None  # or check before access
Not Restoring Original List in Space-Optimized Solutions
In the interleaving approach, failing to properly unweave the two lists corrupts the original list and may break the copied list's pointers. The separation step must correctly restore both next pointers.

# During separation, update both lists
l1.next = l2.next        # restore original
l2.next = l2.next.next   # link copies (check for null first)
*/
