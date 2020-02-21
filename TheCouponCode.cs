using System;

public static class Kata
{
  public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
  {
     var curentDateTime = DateTime.Parse(currentDate);
     var expirationDateTime = DateTime.Parse(expirationDate);
     return (curentDateTime <= expirationDateTime && enteredCode == correctCode);
  }
}