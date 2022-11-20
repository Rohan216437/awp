****************************Test Prime ***************************
using System;
class PrimeNumber
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Name:Sagar Pandey Roll no : 66");
        Console.WriteLine("enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for(int i=2;i<num;i++)
        {
            if(num%i==0)
            {
                count++;

            }
        }
        if (count == 0)
        {
            Console.WriteLine("Prime number");
        }
        else
        {
            Console.WriteLine(" not Prime number");
        }
        Console.ReadKey();
        }
    }

*************Fibonacci***************************

using System;  
  public class FibonacciExample  
   {  
     public static void Main(string[] args)  
      {  
         int n1=0,n2=1,n3,i,number;    
         Console.Write("Enter the number of elements: ");    
         number = int.Parse(Console.ReadLine());  
         Console.Write(n1+" "+n2+" "); //printing 0 and 1    
         for(i=2;i<number;++i) //loop starts from 2 because 0 and 1 are already printed    
         {    
          n3=n1+n2;    
          Console.Write(n3+" ");    
          n1=n2;    
          n2=n3;    
         }    
      }  
   }  