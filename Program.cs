using System;

namespace learn_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Console.WriteLine("Hello World!");
            // 
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            Console.WriteLine("-WriteLine-----");
            Console.WriteLine(Addition(a, b));
            Console.WriteLine(Subtraction(a, b));
            Console.WriteLine(Multiplication(a, b));
            Console.WriteLine(Division(a, b));
            Console.WriteLine("-Format--------");
            Console.WriteLine("Addition: {0} + {1} = {2}", a, b, Addition(a, b));
            Console.WriteLine("Average: {0} and {1} -> {2}", a, b, Average(a, b));
            Console.WriteLine("-For-----------");
            // for
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                total += i;
            }
            Console.WriteLine(total);
            // fizz buzz
            Console.WriteLine("-fizzbuzz-if---");
            for (int i = 1; i < 101; i++)
            {
                if (i % 15 == 0) Console.WriteLine("Fizz Buzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }

        // returns int
        static int Addition(int a, int b) => a + b;
        static int Subtraction(int a, int b) => a - b;
        static int Multiplication(int a, int b) => a * b;
        static int Division(int a, int b) => a / b;
        static float Average(int a, int b) => (a + b) / 2;
    }
}
