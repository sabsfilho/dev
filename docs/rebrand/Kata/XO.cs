using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    int x = 0;
    int o = 0;
    int z = input.Length / 2;
    
    void check(int i) {
      char c = input[i];
      if (c == 'x' || c == 'X') x++;
      else if (c == 'o' || c == 'O') o++;      
    }
    
    if (input.Length % 2 != 0) z++;
    for(int i=0;i<z;i++){
      check(i);
      int j = input.Length - 1 - i;
      if (i != j){
        check(j);
      }
    }
    
    return x == o;
  }
  
}