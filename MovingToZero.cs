using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
      var nules = 0;
      var list = arr.ToList();
        for (int i = 0; i < list.Count; i++)
        {
            if(list[i]==0){
                list.Remove(list[i]);
                list.Add(0);
            }
        }
        return list.ToArray();
  }
}