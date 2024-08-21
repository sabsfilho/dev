public class Solution {
    public string RemoveStars(string s) {
        var stack = new Stack<char>();
        foreach(var c in s) {
            if (c == '*') {
                if (stack.Count > 0) {
                    stack.Pop();
                }
            }
            else {
                stack.Push(c);
            }
        }
        return 
	        new String(
                stack
                .Reverse()
                .ToArray()
            );
    }
}