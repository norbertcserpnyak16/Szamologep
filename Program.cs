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
			double osszeadas = Math.Round(a + b, 4);
			double kivonas = Math.Round(a - b, 4);
			double szorzas = Math.Round(a * b, 4);
			double osztas = Math.Round(a / b, 4);

			//Változókkal való müveletek eredményének a kiiratása!
			Console.WriteLine($"Ez az A és B változó összeadásának eredménye: {osszeadas}");
			Console.WriteLine($"Ez az A és B változó kivonásának eredménye: {kivonas}");
			Console.WriteLine($"Ez az A és B változó szorzásának eredménye: {szorzas}");
			Console.WriteLine($"Ez az A és B változó szorzásának eredménye: {osztas}");
		}

		
	}
}

