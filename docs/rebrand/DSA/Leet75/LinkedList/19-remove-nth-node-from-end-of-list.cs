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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //sliding window
        var curr = head;
        ListNode left = null;
        ListNode prev = null;
        int i = 0;
        int j = 0;
        while(curr != null) {
            prev = left;
            if (i < n) {
                if (left == null) left = curr;
                i++;
            }
            else {
                left = left.next;
            }
            curr = curr.next;
            j++;
        }
        if (prev == null) return null;
        //Console.WriteLine("i="+i+";j="+j+"p="+prev.val);
        if (j > 1 && i == j){
            return prev.next;
        }

        if (prev.next != null) {
            prev.next = prev.next.next;
        }

        return head;
    }
}