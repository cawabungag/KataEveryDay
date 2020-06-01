public class SplitString
{
  public static string[] Solution(string str)
  {
    var ans = "";
    for (int i = 0; i < str.Length; i++)
    {
        ans+=str[i];
        if(i%2!=0){
            ans+=",";
        }
    }
    if(str.Length%2!=0){
        ans+="_";
    }
    return ans.Split(",");
  }
}