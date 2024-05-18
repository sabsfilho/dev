using System;
using System.Linq;
public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    //16:15-16:23
    return 
      string.Join(
        string.Empty, 
        new int[]{ r, g, b }
          .Select(x=>Math.Max(0,Math.Min(x,255)).ToString("X").PadLeft(2, '0'))
      );
    
  }
}