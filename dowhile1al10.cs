using System;

namespace selectivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 0;
            do
            {
                x = x + 1;
                Console.WriteLine(" " + x);

            } while (x != 10);

            Console.WriteLine("Oprime una tecla para continuar "); Console.ReadKey();


        }
    }
}
