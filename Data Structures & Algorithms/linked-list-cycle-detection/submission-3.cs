/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null){
            return false;
        }

        HashSet<int> visited = new();
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;

            if(slow == fast){
                return true;
            }
        }
        
        return false;
    }
}

/*
Common Pitfalls
Not Checking if Fast Pointer Can Advance Safely
Before moving the fast pointer two steps, you must verify both fast and fast.next are not null. Checking only fast != null before accessing fast.next.next causes a null pointer exception when the list has an odd number of nodes without a cycle.

Comparing Node Values Instead of Node References
The cycle detection requires comparing whether two pointers reference the same node object, not whether they have the same value. Using value equality (slow.val == fast.val) incorrectly detects cycles when two different nodes happen to have the same value.
*/
