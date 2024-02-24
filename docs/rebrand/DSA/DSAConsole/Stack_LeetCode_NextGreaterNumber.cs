
using System.Collections;
using System.Collections.Generic;

class Stack_LeetCode_NextGreaterNumber
{

    public static void Print(){

        var xs = new int[] { 4, 7, 3, 4, 8, 1 };

        var rs = Build(xs);

        Console.WriteLine(string.Join(",", rs));
    }

    private static int[] Build(int[] xs)
    {
        var rs = new int[xs.Length];
        var lifo = new Stack<int>();
        for(int i = xs.Length - 1; i >= 0; i--){
            
            int x = xs[i];
            
            while (
                lifo.Count > 0 &&
                lifo.Peek() <= x
            ){
                lifo.Pop();
            }

            if (lifo.Count == 0) {
                rs[i] = -1;
            }
            else {
                rs[i] = lifo.Peek();
            }

            lifo.Push(x);
        }

        return rs;
    }
}