public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        /*
for each person in the line 
    increment steps
    reduce qty
    if qty > 0
        queue index
for each person in the queue
    increment steps
    take tickets[index] and reduce qty
    tickets[k] = 0 return steps
    if qty > 0
        queue index

        */
        var queue = new Queue<int>(); //index position

        int steps = 0;
        for(int i = 0; i < tickets.Length; i++){
            steps++;
            int q = tickets[i];
            q--;
            if (q > 0) {
                tickets[i] = q;
                queue.Enqueue(i);
            }
            else if (i == k) {
                return steps;
            }
        }
        while(queue.Count > 0){
            int i = queue.Dequeue();
            steps++;
            int q = tickets[i];
            q--;
            if (q > 0) {
                tickets[i] = q;
                queue.Enqueue(i);
            }
            else if (i == k) break;
        }
        
        return steps;

    }
}