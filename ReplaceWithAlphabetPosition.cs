using System;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    text = DeleteCharacters(text);
    text.ToUpper();
    var chars = text.ToCharArray();
    text ="";
    for (int i = 0; i < chars.Length; i++)
    {
        int index = Array.IndexOf(alpha,chars[i++]);
        text += index;
    }
    return text;
  }

  static string DeleteCharacters(string str){
    var charsToRemove = new string[] { "@", ",", ".", ";", "'"," "};
    foreach (var c in charsToRemove)
    {
        str = str.Replace(c, string.Empty);
    }
    return str;
  }
}