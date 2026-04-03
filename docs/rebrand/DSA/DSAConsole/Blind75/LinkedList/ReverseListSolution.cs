public class ReverseListSolution {
    // Reverse Linked List
public class ListNode {
     public int val;
     public ListNode? next;
     public ListNode(int val=0, ListNode? next=null) {
         this.val = val;
         this.next = next;
     }
}
 
    public ListNode? ReverseList(ListNode? head) {
        /*
        swap solution
        A -> B -> C
        C -> B -> A
        loop until next is null
        A.next = B
        B.next = C
        C.next = null

        curr = head
        prev = null

        tmp = curr[A].next[B]
        curr[A].next = prev[null]
        prev = curr[A]
        curr = temp[B]

        tmp = curr[B].next[C]
        curr[B].next = prev[A]
        prev = curr[B]
        curr = temp[C]
        
        tmp = curr[C].next[null]
        curr[C].next = prev[B]
        prev = curr[C]
        curr = temp[null]
        */
        var curr = head;
        ListNode? prev = null;

        while(curr != null) 
        {
            var tmp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tmp;
        }

        return prev ?? curr;
    }

    public ListNode? ReverseListStackSolution(ListNode? head) {
        /*
        0->1->2->3->null
        loop to tail -> add node to stack
        current = tail stack.pop
        loop stack current.next = pop
        3[next]->prev
        */
        if (head == null) return null;
        
        var stack = new Stack<ListNode>();
        var curr = head;
        while(curr != null)
        {
            stack.Push(curr);
            curr = curr.next;
        }
        head = stack.Pop();
        ListNode prev = head;
        head.next = null;
        while(stack.Count > 0)
        {
            curr = stack.Pop();
            prev.next = curr;
            prev = curr;
        }
        prev.next = null;

        return head;        
    }
}
