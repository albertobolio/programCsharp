using System;

namespace vectorysuma
{
	class Program
	{
		public static void Main(string[] args)
		{

			int s = 0, i;

			//Arreglo llamado vector

			int[] n = new int[5];

			for (i = 0; i <= 4; i = i + 1)
			{
				Console.Write("Introduce el valor: ");
				n[i] = int.Parse(Console.ReadLine());

			}

			for (i = 0; i <= 4; i = i + 1)

				s = s + n[i];


			Console.WriteLine("La suma del vector de 5 valores es = "+ s);


			Console.ReadKey();



		}
	}
}
