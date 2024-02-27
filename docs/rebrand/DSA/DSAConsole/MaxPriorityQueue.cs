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

    public int DeleteMax() {
        int max = heap[1];
        Swap(1, n);
        n--;
        Sink(1);
        heap[n+1] = 0;
        if (n > 0 && (n == (heap.Length - 1)/4)) {
            Array.Resize(ref heap, heap.Length/2);
        }
        return max;
    }
    private void Sink(int k) {
        while(2*k <= n){
            int j = 2*k;
            if (j < n && heap[j] < heap[j+1]){
                j++;
            }
            if (heap[k] >= heap[j]){
                break;
            }
            Swap(k,j);
            k=j;
        }
    }

    private void Swap(int a, int b) {
        int temp = heap[a];
        heap[a] = heap[b];
        heap[b] = temp;
    }

    public static void Print() {
        var pq = new MaxPriorityQueue(3);

        pq.Insert(4);
        pq.Insert(5);
        pq.Insert(2);
        pq.Insert(6);
        pq.Insert(1);
        pq.Insert(3);
//pq.DeleteMax();
        Console.WriteLine(string.Join(",", pq.Heap));
    }
}