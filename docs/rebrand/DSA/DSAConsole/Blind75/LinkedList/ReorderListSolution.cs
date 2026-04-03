public class ReorderListSolution {
   // Reorder Linked List
public class ListNode {
     public int val;
     public ListNode? next;
     public ListNode(int val=0, ListNode? next=null) {
         this.val = val;
         this.next = next;
     }
}
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;

        // Find middle
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next!;
            fast = fast.next.next!;
        }

        // Reverse second half
        ListNode? prev = null, curr = slow.next;
        slow.next = null;
        while (curr != null) {
            ListNode next = curr.next!;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        // Merge lists
        ListNode? first = head, second = prev;
        while (second != null) {
            ListNode? tmp1 = first!.next;
            ListNode? tmp2 = second.next;
            first.next = second;
            second.next = tmp1;
            first = tmp1;
            second = tmp2;
        }
    }
}