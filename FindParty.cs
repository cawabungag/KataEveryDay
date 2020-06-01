using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
   int result = -1;

    if (integers != null && integers.Length > 2) {

        for (int i = 2; i < integers.Length; i++) {
            if (isEven(integers[i]))
                if ( isOdd(integers[i - 1]) && isOdd(integers[i - 2]))
                    return i;
            if ( isEven(integers[i - 1]) && isOdd(integers[i - 2] ))
                return i - 2;
            else if ( isOdd(integers[i - 1]) && isEven(integers[i - 2]))
                return i - 1;
            if (isOdd(integers[i]))
                if (isEven(integers[i - 1]) && isEven(integers[i - 2]))
                    return i;
            if (isOdd(integers[i - 1]) && isEven(integers[i - 2]))
                return i - 2;
            else if (isEven(integers[i - 1]) && isOdd(integers[i - 2]))
                return i - 1;
        }
    }

    return result;
}

public static bool isEven(int number){
   return (number % 2 == 0);
}
public static bool isOdd(int number){
   return (number % 2 == 1);
}
}