public class ValidParenthesesSolution {
    public bool IsValid(string s) {
        /*
        ()
        []
        {}
        stack last in first out
        open push
        close pop
        */
        if (s.Length < 2) return false;

        bool IsOpen(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }
        char GetClose(char c)
        {
            return 
                c == '(' ? ')' :
                c == '[' ? ']' :
                c == '{' ? '}' :
                '\0';
        }
        bool hasOpen = false;
        var stack = new Stack<char>();
        for(int i=0;i<s.Length;i++)
        {
            char c = s[i];
            if (IsOpen(c)) {
                hasOpen = true;
                stack.Push(c);
            }
            else if (stack.Count > 0) {
                var v = stack.Pop();
                if (c != GetClose(v)) return false;                
            }
            else return false;
        }
        return hasOpen && stack.Count == 0;
    }
}
