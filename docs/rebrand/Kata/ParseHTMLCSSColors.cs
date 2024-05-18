using System;
using System.Collections.Generic;
//16:31-16:47
class HtmlColorParser
{
    private readonly IDictionary<string, string> presetColors;

    public HtmlColorParser(IDictionary<string, string> presetColors)
    {
        this.presetColors = presetColors;
    }

    public RGB Parse(string color)
    {
      if (color[0] == '#') {
        if (color.Length == 7) {
          return new RGB(
            Convert.ToByte(color.Substring(1,2), 16),
            Convert.ToByte(color.Substring(3,2), 16),
            Convert.ToByte(color.Substring(5,2), 16)
          );
        }
        if (color.Length == 4) {
          return new RGB(
            Convert.ToByte(GetXX(color.Substring(1,1)), 16),
            Convert.ToByte(GetXX(color.Substring(2,1)), 16),
            Convert.ToByte(GetXX(color.Substring(3,1)), 16)
          );
        }
      }
      else {
        color = color.ToLower();
        if (presetColors.ContainsKey(color)) {
          return Parse(presetColors[color]);
        }
      }
      throw new Exception($"invalid color {color}");
    }
  
    static string GetXX(string x) {
      return string.Concat(x,x);
    }
}
