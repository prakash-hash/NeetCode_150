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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null)
            return;

        Stack<ListNode> st = new();
        ListNode curr = head;
        int size = 0;

        while (curr != null) {
            st.Push(curr);
            curr = curr.next;
            size++;
        }

        curr = head;

        for (int i = 0; i < size / 2; i++) {
            ListNode last = st.Pop();
            ListNode next = curr.next;

            curr.next = last;
            last.next = next;

            curr = next;
        }

        curr.next = null;  // critical
    }
}
