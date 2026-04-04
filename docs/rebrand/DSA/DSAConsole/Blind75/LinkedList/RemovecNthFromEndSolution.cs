public class RemovecNthFromEndSolution {
//Remove Node From End of Linked List
public class ListNode {
     public int val;
     public ListNode? next;
     public ListNode(int val=0, ListNode? next=null) {
         this.val = val;
         this.next = next;
     }
}
    public ListNode RemovecNthFromEnd(ListNode head, int n) {        
        /*
        A => B => C => D, length = 4, n = 1, skip = 4 - 1 = 3, C.next = c.next.next
        loop to find length
        loop to skip
        set curr.next = curr.next.next
        */

        int length = 0;
        ListNode curr = head;
        while(curr != null)
        {
            length++;
            curr = curr.next!;
        }
        int skip = length - n;
        if (length == 1 && n == 1) return null!;
        if (skip == 0) return head.next!;
      
        curr = head;
        int i = 1;
        while(curr != null)
        {
            if (i == skip)
            {
                if (curr.next != null) 
                    curr.next = curr.next.next;
                break;
            }
            i++;
            curr = curr.next!;
        }

        return head;
    }
}
