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

        while(currH1 != null && currH2 != null){
            int sum = currH1.val + currH2.val + carry;
            carry = sum/10;
            currNewH.next = new ListNode(sum%10);
            currNewH = currNewH.next;
            currH1 = currH1.next;
            currH2 = currH2.next;
        }

        while(currH1 != null){
            int sum =  currH1.val + carry;
            carry = sum/10;
            currNewH.next = new ListNode(sum%10);
            currNewH = currNewH.next;
            currH1 = currH1.next;
        }

        while(currH2 != null){
            int sum = currH2.val + carry;
            carry = sum / 10;
            currNewH.next = new ListNode(sum%10);
            currNewH = currNewH.next;
            currH2 = currH2.next;
        }

        if(carry == 1){
            currNewH.next = new ListNode(1);
        }

        return newHead.next;
    }
}
