using System;
using System.Linq;
public class Kata
{
  public static string BreakCamelCase(string str)
  {
    var list = str.ToCharArray().ToList();
    for (int i = 0; i < list.Count; i++)
    {
        if(list[i].IsUpper()){
            list[i] = " "+list[i];
        }
    }
    return list.ToString();
  }
}