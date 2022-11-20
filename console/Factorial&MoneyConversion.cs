*************************Factorial*************************
using System;  
  public class FactorialExample  
   {  
     public static void Main(string[] args)  
      {  
       int i,fact=1,number;      
       Console.Write("Enter any Number: ");      
       number= int.Parse(Console.ReadLine());     
       for(i=1;i<=number;i++){      
        fact=fact*i;      
       }      
       Console.Write("Factorial of " +number+" is: "+fact);    
     }  
  }  

  ***********************Money Coversion*************************

  using System;
namespace Demo
{
public class Program
{
    public static void Main(string[] args)
    {

        int inr, val , usd;
        // how many dpllars
        Console.Write("How many USD you want to convert to INR : ");      
        usd = int.Parse(Console.ReadLine()); 
        // usd = 10;
        // current value of US$
        val = 69;
        inr = usd * val;
        Console.WriteLine("{0} Dollar = {1} INR", usd, inr);
    }
}
}