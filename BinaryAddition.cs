using System;

public static class Kata
{
  public static string AddBinary(int a, int b)
  {
   // your code ...
   int binary = a + b;
   
   string result = Convert.ToString(binary,2);
   
   return result;
   
  }
}