//Last-digit-of-a-large-number

using System;

namespace Solution
{
  using System.Numerics;
  
  class LastDigit
  {
    public static int GetLastDigit(BigInteger n1, BigInteger n2)
    {
      //reference
      //brilliant.org/wiki/finding-the-last-digit-of-a-power/ 
      
      string e = n2.ToString();
      if (e == "0") return 1;
      string n = n1.ToString();
      if (n == "0") return 0;
      
      int m = 0;

      for (int i = 0; i < e.Length; i++){
          m = (m * 10 + e[i] - '0') % 4;
          //Console.WriteLine(m);
      }
      if (m == 0) m = 4;
      
      int v = Convert.ToInt32(Math.Pow(int.Parse(n.Substring(n.Length-1)), m));
      /*
      Console.WriteLine(n);
      Console.WriteLine(e);
      Console.WriteLine(v);
      */
      if (v > 9) {
        v = v % 10;
      }
      
      return v;
    }
  }
}