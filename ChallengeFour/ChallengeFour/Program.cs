using System;

namespace ChallengeFour
{
    class Program
    {
        static void Main() 
        {
            var DreamCar = new Vehicle(4, "Truck", 2017, "Jeep");
            var HateCar = new Vehicle(4, "", 2010, "Beetle");
            Console.WriteLine("My dream car is a" + " " + DreamCar.Year + " " + DreamCar.Model);
            Console.WriteLine("A car I would hate to own is a" + " " + HateCar.Year + " " + HateCar.Model);
        }
    }
	public class Vehicle
	{
		public int Tires { get; set; }
		public string Type { get; set; }
		public int Year { get; set; }
		public string Model { get; set; }

        public Vehicle(int tires, string type, int year, string model) 
        {
            Tires = tires;
            Type = type;
            Year = year;
            Model = model;
        }
	}
}
