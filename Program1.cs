using System;

namespace Második
{
	class Program
	{
		static void Main(string[] args)
		{
			int szam = int.Parse(Console.ReadLine());
			if (szam % 2 == 0)
			{
				Console.WriteLine("Páros");
			}
			else
			{
				Console.WriteLine("Páratlan");
			}
			Console.ReadKey();



		}
	}
}
