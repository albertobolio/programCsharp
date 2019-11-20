using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablapares2al10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {
                x = x + 2;
                Console.WriteLine(" " + x);

            } while (x != 10);

            Console.WriteLine("Oprime una tecla para continuar "); Console.ReadKey();

        }
    }
}
