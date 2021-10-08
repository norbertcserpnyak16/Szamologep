using System;


namespace Szamologep
{
	class Program
	{

		static void Main(string[] args)
		{
			//Stringek bekérése és kiiratása!
			//Console.WriteLine("Írj be egy szót!");
			//string y = Console.ReadLine();
			//Console.ReadKey();
			//Console.WriteLine("Az általad bekért Stringek:" + y);

			//változókkal való műveletek!
			Console.WriteLine("Írj be egy számot!");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Írj be még egy számot!");
			int b = int.Parse(Console.ReadLine());
			int ab = a + b;
			int ab2 = a - b;
			int ab3 = a * b;
			int ab4 = a / b;

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
		static bool Pozitiv(int szam)
		{
			return szam >= 0;
		}
	}
}

