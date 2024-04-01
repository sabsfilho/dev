public class Solution {
    public bool IsValid(string s) {
        if (s == null || s.Length < 2) return false;
        var map = new Dictionary<char,char>(){
{ '{','}' },
{ '[',']' },
{ '(',')' },
        };
        var map2 = new Dictionary<char,char>();
        foreach(var x in map){
            map2[x.Value] = x.Key;
        }
        var lifo = new Stack<char>();
        foreach(char c in s){
            if (map.ContainsKey(c)){
                lifo.Push(c);
            }
            else if (
                (lifo.Count == 0 && map2.ContainsKey(c)) ||
                (lifo.Count > 0 && map2.ContainsKey(c) && lifo.Pop()!=map2[c])
                ){
                return false;
            }

        }
        return lifo.Count == 0;
    }
}