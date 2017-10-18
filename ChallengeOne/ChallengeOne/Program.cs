using System;

namespace ChallengeOne
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to be divided!");

            var dividend = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the number you want that number to be divided by!");

            var divisor = Convert.ToInt16(Console.ReadLine());

            var quotient = Divide(dividend, divisor);

            Console.WriteLine("The answer is " + quotient);


        }
		public static int Divide(int dividend, int divisor)
		{
            int results = dividend / divisor;
            return results;
		}

    }
}
