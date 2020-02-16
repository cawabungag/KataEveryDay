using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
      var chars = input.ToCharArray();
      var countX = 0;
      var countO = 0;

        foreach(char ch in chars){
            var str = ch.ToString();
            if(str == "X" || str == "x"){
                countX++;
            }
            if(str == "O" || str == "o"){
                countO++;
            }
        }   
    return countO == countX;
  }
}