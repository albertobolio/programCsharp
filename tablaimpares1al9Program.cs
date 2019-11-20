using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaimpares1al9{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            do
            {
                x = x + 2;
                Console.WriteLine(" " + x);

            } while (x != 9);

            Console.WriteLine("Oprime una tecla para continuar "); Console.ReadKey();

        }
    }
}
