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
			double ab = Math.Round(a + b, 4);
			double ab2 = Math.Round(a - b, 4);
			double ab3 = Math.Round(a * b, 4);
			double ab4 = Math.Round(a / b, 4);

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

