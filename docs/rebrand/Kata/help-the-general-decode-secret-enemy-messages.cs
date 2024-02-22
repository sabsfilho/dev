using System;
using System.Text;

public static class Decoder
{
    public static string Decode(string p_what)
    {
      
      string cs = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,? ";
      string w = string.Empty.PadLeft(p_what.Length, '_');
      
      string r = string.Empty;
      for(int i=0;i<p_what.Length;i++){
        char[] ws = w.ToCharArray();
        char p = p_what[i];
        if (cs.Contains(p)){
          foreach(char c in cs){
            ws[i] = c;
            char v = Encoder.Encode(new String(ws))[i];
            if (v==p){
              r = string.Concat(r, c);
              break;
            }
          }
        }
        else {
            r = string.Concat(r, p);          
        }
      }
      return r;
    }
  
  
}