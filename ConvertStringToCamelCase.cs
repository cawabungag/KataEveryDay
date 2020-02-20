using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    if(str.Contains("-") && str.Contains("_")){
          var ans = SplitString(str,"-");
          return SplitString(ans,"_");
      }
    if(str.Contains("-")){
        return SplitString(str,"-");
    }
    if(str.Contains("_")){
        return SplitString(str,"_");
    }
    return String.Empty();
  }

  static string SplitString(string str, string _case){
      var strs=str.Split(_case);
      var ans = "";
        for (int i = 1; i < strs.Length; i++)
        {
            strs[i] = UppercaseFirst(strs[i]);
        }
        foreach (var item in strs)
        {
            ans+=item;
        }
    return ans;
  }
  static string UppercaseFirst(string s)
    {
        return char.ToUpper(s[0]) + s.Substring(1);
    }
}