using System;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        List<int> aNumbers = new List<int>();
        List<int> bNumbers = new List<int>();

        if(b.Length > a.Length){
            string t = b;
            b = a;
            a = t;
        }
       foreach(char aChar in a.ToCharArray){
           aNumbers.Add(Int32.Parse(aChar));
       }
       foreach(char bChar in b.ToCharArray()){
           bNumbers.Add(Int32.Parse(bChar));
       }
       
    }