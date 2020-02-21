using System.Linq;
public class Kata
{
     public static void Main () 
    { 
        int []arr = {1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9}; 
        int n = arr.Length; 
        pushZerosToEnd(arr, n); 
        Console.WriteLine("Array after pushing all zeros to the back: "); 
        for (int i = 0; i < n; i++) 
        Console.Write(arr[i] +" "); 
    } 
  public static int[] MoveZeroes(int[] arr)
  {
      var nules = 0;
      var list = arr.ToList();
        for (int i = 0; i < list.Count; i++)
        {
            if(list[i]==0){
                list.RemoveAt(i);
                nules++;
            }
        }
        for (int i = 0; i < nules; i++)
        {
            list.Add(0);
        }
        return list.ToArray();
  }
}