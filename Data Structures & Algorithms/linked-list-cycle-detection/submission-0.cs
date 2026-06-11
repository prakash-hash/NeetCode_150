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
        while(head.next != null){
            if(visited.Contains(head.val)){
                return true;
            }

            visited.Add(head.val);
            head = head.next;
        }
        
        return false;
    }
}
