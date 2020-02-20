using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    var res = 0;
    for (int i = 0; i < numbers.Count; i++)
    {
        for (int i = numbers.Count - 1; i >= 0 ; i--)
        {
            if(numbers[i] != numbers[j]){
                res = numbers[i];
            }
        }
    }
    return res;
  }
}