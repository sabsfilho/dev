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
    public ListNode RemoveNodes(ListNode head) {
        if (head == null) return null;

        var stack = new Stack<ListNode>();

        ListNode main = new ListNode(int.MaxValue, head);
        stack.Push(main);
        ListNode n = head;
        while(n != null){
            stack.Push(n);
            n = n.next;
        }
        n = stack.Pop();
        while(stack.Count > 0) {
            var x = stack.Pop();
            if (x.val >= n.val) {
                x.next = n;
                n = x;
            }

        }

        return main.next;
        
    }
}