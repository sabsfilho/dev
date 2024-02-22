public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    if (walk.Length != 10) return false;
    
    int h = 0;
    int v = 0;
    foreach(string c in walk){
      if (c == "n") h++;
      else if (c == "s") h--;
      else if (c == "w") v--;
      else if (c == "e") v++;
    }
    return h == 0 && v == 0;
  }
}