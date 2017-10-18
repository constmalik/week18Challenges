using System;

namespace Challenge2
{
	class Program
	{
		class Car
		{
			public int numberOfTires { get; set; }
			public int year { get; set; }
			public string model { get; set; }
		}
		class MainClass
		{
			static void Main()
			{
				var car1 = new Car
				{
					numberOfTires = 4,
					year = 2004,
					model = "Honda"
				};
				Console.WriteLine($"Model: {car1.model} Year: {car1.year}");
				var car2 = new Car
				{
					numberOfTires = 4,
					year = 2010,
					model = "Ford"
				};
				Console.WriteLine($"Model: {car2.model} Year: {car2.year}");
				var car3 = new Car
				{
					numberOfTires = 4,
					year = 2006,
					model = "Toyota"
				};
				Console.WriteLine($"Model: {car3.model} Year: {car3.year}");
			}
		}
	}
}

