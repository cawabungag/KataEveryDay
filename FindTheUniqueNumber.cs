using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    var list = numbers.ToList;
    var ans = list.Distinct();
    return ans.First();
  }
}