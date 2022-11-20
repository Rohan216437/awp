*****************************FunctionOverloading**************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Function_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.sum();
            Calculator.sum(5,4);
            Calculator.sum(9.3f, 8.6f);
            Calculator.sum("Hello World");
            Console.Read();
        }
    }
    static class Calculator
    {
        public static void sum()
        {
            Console.WriteLine("No Value Provided");
        }
        public static void sum(int x, int y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(float x, float y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(string s)
        {
            Console.WriteLine("{0} - is not a numeric value", s);
        }
    }
}

********************************Inheritance***************************
***********************A.Single inheritance:
class Program
    {
        class A
        {
            public void hii()
            {
                Console.WriteLine("from class A ,hii");
            }
        }

        class B:A
        {
            public void hello()
            {
                Console.WriteLine("from class B ,hello");
            }
        }

        // Main Method
        public static void Main(String[] args)
        {
            B ObjB = new B();
           ObjB.hii();
           ObjB.hello();
            Console.ReadLine();
        }
    
 **************************B.multilevel 
  class Program
    {
        class A
        {
            public void hii()
            {
                Console.WriteLine("from class A ,hii");
            }
        }

        class B:A
        {
            public void hello()
            {
                Console.WriteLine("from class B ,hello");
            }
        }
        class C : B
        {
            public void GOODMORNING()
            {
                Console.WriteLine("from class C ,Good Morning");
            }
        }

        // Main Method
        public static void Main(String[] args)
        {
            C ObjC = new C();
           ObjC.hii();
           ObjC.hello();
            ObjC.GOODMORNING();
            Console.ReadLine();
        }


 *******************************C: hierarchical
    class A
        {
            public void hii()
            {
                Console.WriteLine("from class A ,hii");
                
            }
        }

        class B:A
        {
            public void hello()
            {
                Console.WriteLine("from class B ,hello");


            }
        }
        class C : A
        {
            public void GOODMORNING()
            {
                Console.WriteLine("from class C ,Good Morning");
            }
        }

        // Main Method
        public static void Main(String[] args)
        {
            C ObjC = new C();
           ObjC.hii();
           
            ObjC.GOODMORNING();
            B ObjB = new B();
            ObjB.hello();
            ObjB.hii();
            A ObjA = new A();
            ObjA.hii();
}

***************************multiple 
class Program
    {
       
       
            interface A
            {
            void add();
                
            }
        
        interface B
        {
            void Sub();
            
        }
        class C :A,B
        {
            public void add()
            {
                int a = 20; int b = 10;
                Console.WriteLine(a + b);

            }            
            public void Sub()
            {
                int a = 20; int b = 10;
                Console.WriteLine(a - b);

            }
        }

        // Main Method
        public static void Main(String[] args)
        {
            C objC = new C();
            objC.add();
            objC.Sub();


            Console.ReadLine();
        }
    }
