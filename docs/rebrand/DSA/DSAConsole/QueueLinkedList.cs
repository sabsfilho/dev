
public class QueueLinkedList<T>{
//FIFO
    class ListNode<K> {
        public K data;
        public ListNode<K>? next = null;

        public ListNode(K data){
            this.data = data;
            this.next = null;
        }
    }

    ListNode<T>? front;
    ListNode<T>? rear;

    public int Length { get; private set; }

    public void Enqueue(T data){
        var t = new ListNode<T>(data);
        if (front == null){
            front = t;
            rear = t;
            return;
        }
        if (rear == null) rear = t;
        rear.next = t;
        rear = t;
        Length++;
    }

    public T Dequeue() {
        if (front == null) {
            throw new NullReferenceException();
        }
        T r = front.data;
        front = front.next;
        if (front == null) {
            rear = null;
        }
        Length--;
        return r;
    }
    private void Print()
    {
        if (front == null) return;
        
        ListNode<T> n = front;

        while(n != null) {
            Console.Write($"{n.data} => ");
            n = n.next;
        }
        Console.WriteLine("null");
    }

    public static void Load() {
        var fifo = new QueueLinkedList<int>();
        fifo.Enqueue(10);
        fifo.Enqueue(15);
        fifo.Enqueue(20);
        fifo.Print();
        fifo.Dequeue();
        fifo.Print();
    }

}