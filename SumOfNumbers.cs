public class SequenceSum
{
  public static string ShowSequence(int n)
  {    
      var str = "";
      var sum = 0;

      if(n<0)
      {
          return n.ToString+"<0";
      }
      if(n = 0){
          return "0=0";
      }
      for (int i = 0; i <= n; i++)
      {
          str += i.ToString();
          sum += i;
          if(i != n){
            str+= "+";
          }
      }
      str += " = ";
      str += "" + sum.ToString();
    return str;
  }
}