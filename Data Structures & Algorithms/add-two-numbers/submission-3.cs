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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        ListNode currH1 = l1;
        ListNode currH2 = l2;
        ListNode newHead = new ListNode(0);
        ListNode currNewH = newHead;

        while(currH1 != null || currH2 != null || carry > 0){
            int x = currH1?.val ?? 0;
            int y = currH2?.val ?? 0;

            int sum = x + y + carry;
            
            carry = sum/10;
            
            currNewH.next = new ListNode(sum%10);
            
            currNewH = currNewH.next;
            currH1 = currH1?.next;
            currH2 = currH2?.next;
        }

        return newHead.next;
    }
}

/*
Common Pitfalls
Forgetting the Final Carry
When both lists are exhausted, there may still be a carry of 1 (e.g., 999 + 1 = 1000). Stopping the loop early without checking for remaining carry produces an incorrect result.

# Wrong: missing carry check
while l1 or l2:  # Should be: while l1 or l2 or carry
    # ...
Not Handling Lists of Different Lengths
When one list is longer than the other, the loop must continue processing the remaining nodes. Using l1 and l2 instead of l1 or l2 stops too early.

# Wrong: requires both lists to have nodes
while l1 and l2:  # Stops when either list ends
    # ...
*/
