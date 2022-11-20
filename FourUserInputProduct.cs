using System;
class Practical_1a
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Name: name"
            + "\n Roll no:00");

        Console.WriteLine("Enter four number");

        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Entered number are:");

        Console.WriteLine("  number 1: {0}",num1);
        Console.WriteLine("  number 2: {0}", num2);
        Console.WriteLine(" number 3: {0}", num3);
        Console.WriteLine(" number 4: {0}", num4);
        int Product = num1 * num2 * num3 * num4;

        Console.WriteLine("Product = {0}",Product);

        Console.ReadKey();

   }
}
