using System.Runtime.InteropServices;

class MaxPriorityQueue {
    private int[] heap;
    public int[] Heap{
        get {
            return heap.Skip(1).Take(n).ToArray();
        }
    }
    private int n;

    public MaxPriorityQueue(int capacity){
        heap = new int[capacity+1];
        n = 0 ;
    }

    public bool IsEmpty(){
        return n == 0;
    }

    public int Size() {
        return n;
    }

    public void Insert(int x) {
        if (n == heap.Length - 1) {
            Array.Resize(ref heap, 2*heap.Length);
        }
        n++;
        heap[n] = x;
        swim(n);
    }

    private void swim(int k) {
        while (k > 1 && heap[k/2] < heap[k]){
            int temp = heap[k];
            heap[k] = heap[k/2];
            heap[k/2] = temp;
            k = k/2;
        }
    }

    public static void Print() {
        var pq = new MaxPriorityQueue(3);

        pq.Insert(4);
        pq.Insert(5);
        pq.Insert(2);
        pq.Insert(6);
        pq.Insert(1);
        pq.Insert(3);

        Console.WriteLine(string.Join(",", pq.Heap));
    }
}