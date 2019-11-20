using System;

namespace fibonacci
{
	class Program
	{
		public static void Main(string[] args)
		{
			/* SOLUCIÓN CREADA POR : ING. ALBERTO BOLIO SALAZAR */

			/* La sucesión de Fibonacci es asi:          0-1-1-2-3-5-8-13-21
			 observemos la interacción de las variable: p1 toma el valor inicial de 0 o sea p1=0
			 observemos la interacción de las variable: s2 toma el valor inicial de 1 o sea s2=1
             observemos la interacción de las variable: z es la suma de p1 mas s2 o sea     z=p1+s2
             AQUI VIENE LA SOLUCIÓN DE COMO GENERAR LOS VALORES SIGUIENTES: p1 salta a tomar el valor de s2, y s2 salta a tomar el valor de z dentro del ciclo for */


			int p1 = 0, s2 = 1, z;
			int x, cuantas;
			Console.Write("Cuantas iteraciones quieres calcular de la sucesión de Fibonacci:¿?:");
			cuantas = int.Parse(Console.ReadLine());


			Console.WriteLine(p1);
			Console.WriteLine(s2);


			for (x = 1; x <= cuantas-2; x = x + 1)
			{
				z = p1 + s2;
				 
				Console.WriteLine(z);
				p1 = s2;
				s2 = z;

			}
			Console.Write("Oprima una tecla para continuar"); Console.ReadKey();


		}
	}
}
