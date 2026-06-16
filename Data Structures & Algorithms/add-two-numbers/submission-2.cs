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
