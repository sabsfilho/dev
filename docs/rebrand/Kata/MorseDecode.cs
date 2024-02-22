	public static string Decode(string morseCode)
	{
    return
      string.Join(
        string.Empty,
        morseCode
          .Split(' ')
          .Select(x=>x.Length == 0 ? " " : MorseCode.Get(x))
      )
      .Replace("  ", " ")
      .Trim();
      
	}