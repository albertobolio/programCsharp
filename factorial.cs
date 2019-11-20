using System;

namespace factorial
{
	class Program
	{
		public static void Main(string[] args)
		{

			int x, f = 1, n;

			Console.Write("Hasta que valor quieres calcular el factorial:");
			n = int.Parse(Console.ReadLine());

			for (x = 1; x <= n; x=x+1)

				f = f * x;

			Console.WriteLine("El factorial de:" + n + " es:" + f);
			Console.ReadKey();




		}
	}
}
