using System;
using System.Linq;
using System.Collections.Generic;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas veces desea repetir la sucesion? ");
            int Num = Int32.Parse(Console.ReadLine());

            int Fibo(int z)
            {
                int Num = z;
                int a = 1;
                int b = 1;
                int c = 0;
            
                for (int i = 0; i < Num; i++)
                {

                    Console.WriteLine(a);
                    a = b + c;
                    c = b;
                    b = a;
                }
                return z;

            }

            Func<int, int> Hola = (b) =>
            {
                Fibo(b);
                return Num;
            };

            int Fibonacci = Hola(Num);

            Console.ReadKey();
        }
    }
}
