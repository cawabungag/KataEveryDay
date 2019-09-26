using System;

public class Kata
    {
        public  static int Opposite(int number)
        {
            // Happy Coding
           var abs = Math.Abs(number);
           if(number<0){
           abs *= 2;
           number += abs;
           return number;
           }
           else{
           abs *= 2;
           number -= abs;
           return number;}
        }
    }