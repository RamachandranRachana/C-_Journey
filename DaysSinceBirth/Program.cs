using System;

namespace DaysSinceBirth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday in format yyyy-mm-dd");
            string input = Console.ReadLine();
            DateTime dateTime;
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine("Number of Days since Birth: {0}",DateTime.Now.Subtract(dateTime).Days);
            }
            else
            {
                Console.WriteLine("Invalid input!!");
            }
        }
    }
}
