using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    var result = new List<string>();
       foreach (var item in words)
       {
           if(item.CheckAnagram(word)){
               result.Add(item);
           }
       }
       return result;
  }
 private static bool CheckAnagram(this string str1, string str2)
{
    if(str1.Length != str2.Length)
        return false;

    if(str1 == str2)
        return true;
    int charLength = 128; 

    int[] counter = new int[charLength];

    for(int i=0; i<str1.Length; i++)
    {
        counter[str1[i]-'a']++;
        counter[str2[i]-'a']--;
    }

    for (int c = 0; c < charLength; c++) 
    {
        if(counter[c] != 0) return false;
    }

    return true;
}
}