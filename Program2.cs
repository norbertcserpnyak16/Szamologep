using System;

namespace NegativPozitiv
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Páros vagy páratlan");

			int szam = int.Parse(Console.ReadLine());

			if (szam % 2 == 0)
			{
				Console.WriteLine("Páros");
			}
			else
			{
				Console.WriteLine("Negatív");

			}
		}

	}

}