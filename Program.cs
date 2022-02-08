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
            // array 1
            Console.WriteLine("-array-1-------");
            double[] d1 = new double[3];
            d1[0] = 1.2;
            d1[1] = 3.7;
            d1[2] = 4.1;
            double sum1 = 0;
            for (int i = 0; i < d1.Length; i++)
            {
                sum1 += d1[i];
            }
            Console.WriteLine(sum1);
            // array 2
            Console.WriteLine("-array-2-------");
            double[] d2 = { 1.2, 2.3, 3.4, 4.5, 5.6 };
            double sum2 = 0;
            for (int i = 0; i < d2.Length; i++)
            {
                sum2 += d2[i];
            }
            Console.WriteLine(sum2);
            // foreach
            Console.WriteLine("-foreach-------");
            int[] d3 = { 1, 2, 3, 4, 5 };
            foreach (int i in d3)
            {
                Console.WriteLine(i);
            }
            // multidimensional array
            /*
             * 2d: int[,] a = new int[3,4];       -> a[1,2] = 2;
             * 3d: int[,,] a = new int[3,4,5]     -> a[1,2,3] = 2;
             * 4d: int[,,,] a = new int[3,4,5,6]  -> a[1,2,3,4] = 2;
             */
            int[,] mArray = new int[3, 4]; 
            int m, n;
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 4; n++)
                {
                    mArray[m, n] = m + n;
                }
            }
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 4; n++)
                {
                    Console.Write("a[{0},{1}]={2} ", m, n, mArray[m, n]);
                }
                Console.WriteLine();
            }
            // class
            Console.WriteLine("-class---------");
            var User = new User();
            User.ShowInfo();
            User.setInfo("Francis", 18);
            User.ShowInfo();
        }

        // returns int
        static int Addition(int a, int b) => a + b;
        static int Subtraction(int a, int b) => a - b;
        static int Multiplication(int a, int b) => a * b;
        static int Division(int a, int b) => a / b;
        static float Average(int a, int b) => (a + b) / 2;
    }
}
