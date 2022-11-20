*******************************Test For Vowels*****************************888
using System;
    class Practical_1d
    {
    public static void Main(string[] args)
    {
        Console.WriteLine("Name:Sagar Pandey"
+ "\n Roll no =66");
        Console.WriteLine("Enter a character");
        char ch = Char.Parse(Console.ReadLine());
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine("Vowels");
        }
        else
        {
            Console.WriteLine("consonant");
        }
        Console.ReadKey();


    }
}

*****************************ForEachLoop****************************

using System;
class PrimeNumber
{
    public static void Main(string[] args)
    {
        int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
        foreach (int i in numbers)
        {
            System.Console.Write("{0} ", i);
        }
        // Output: 4 5 6 1 2 3 -2 -1 0
    }
}