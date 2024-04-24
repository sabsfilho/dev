public class Solution {
    /*
    2,3,5,7,11,13,17
n=0;d=2
n=2;d=5
n=4;d=11
n=6;d=17
n=3;d=7
n=1;d=3
n=5;d=13
*/
    public int[] DeckRevealedIncreasing(int[] deck) {
        Array.Sort(deck);
        var q = new Queue<int>();
        int i = 0;
        for(i=0;i<deck.Length;i++){
            q.Enqueue(i);
        }
        var arr = new int[deck.Length];
        i = 0;
        while(q.Count>0 ) {
            var n = q.Dequeue();
            arr[n] = deck[i];
            if (q.Count==0) break;
            q.Enqueue(q.Dequeue());
            i++;
        }
        return arr;
    }
}