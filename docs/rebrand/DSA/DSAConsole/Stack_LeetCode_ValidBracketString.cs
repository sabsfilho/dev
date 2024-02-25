class Stack_LeetCode_ValidBracketString
{
    static bool IsValid(string x){

        var d = new Dictionary<char,char> {
            { '(', ')'},
            { '[', ']'},
            { '{', '}'},
        };

        var lifo = new Stack<char>();
        foreach(var c in x){
            if (d.ContainsKey(c)) {
                lifo.Push(c); //open
                continue;
            }

            if (lifo.Count == 0) {
                return false;
            }

            var open = lifo.Peek();
            var close = d[open];

            if (c == close) {
                lifo.Pop();
            }
            else {
                return false;
            }

        }

        return lifo.Count == 0;
    }
    internal static void Print()
    {
        var xs = new string[]{
            "{()}",
            "{[",
            "{()", 
            "(test1)"
        };

        foreach(var x in xs){
            Console.WriteLine($"{x}={IsValid(x)}");
        }
    }
}