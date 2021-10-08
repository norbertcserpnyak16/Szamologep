using System;


namespace Szamologep
{
	class Program
	{

		static void Main(string[] args)
		{

			//változókkal való műveletek!
			Console.WriteLine("Írj be egy számot!");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("Írj be még egy számot!");
			double b = double.Parse(Console.ReadLine());
			double ab = a + b;
			double ab2 = a - b;
			double ab3 = a * b;
			double ab4 = a / b;

			//Változókkal való müveletek eredményének a kiiratása!
			Console.WriteLine($"Ez az A és B változó összeadásának eredménye: {ab}");
			Console.WriteLine($"Ez az A és B változó kivonásának eredménye: {ab2}");
			Console.WriteLine($"Ez az A és B változó szorzásának eredménye: {ab3}");
			Console.WriteLine($"Ez az A és B változó szorzásának eredménye: {ab4}");
		}

		static bool Paros(int szam)
		{
			return szam % 2 == 0;
		}
		static bool Pozitiv(double szam)
		{
			return szam >= 0;
		}
	}
}

