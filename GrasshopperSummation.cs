using System;

public static class Kata 
{
    public static int summation(int num)
    {
      var obj = 0;
      for (int i = 1; i <= num; i++){
      obj += i;
    }
    return obj;
    }
}