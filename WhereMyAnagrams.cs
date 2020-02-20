using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    var result = new List<string>();
       foreach (var item in words)
       {
           if(item.IsContains(word)){
               result.Add(item);
           }
       }
       return result;
  }
  private static bool IsContains(this string words, string letter){
      var letters = letter.ToCharArray();
      var useLetter = new List<char>();
        for (int i = 0; i < letters.Length; i++)
        {
            var letter = letters[i];
           if(!words.Contains(letter)){
               return false;
           }
           useLetter.Add(letter);
        }
        return true;
  }
}