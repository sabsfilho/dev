public static class Kata
{
  public static int Solution(int value)
  {
    return calc(value, 1, 3, 5);
  }
  
  static int calc(int v, int i, int k1, int k2){
    
    if (v <= 0){
      return 0;
    }
    
    int v1 = i * k1;
    if (v1 >= v) {
      return 0;
    }
    
    int v2 = i * k2;
    if (v2 >= v || v2 % k1 == 0) {
      v2 = 0;
    }
    
    return 
      v1 + 
      v2 +
      calc(v, i + 1, k1, k2);
    
  }
}