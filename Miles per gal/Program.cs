using System;

namespace Miles_per_gal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of miles driven: ");     
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the gas consumed: ");
            double gas = double.Parse(Console.ReadLine());

            Console.WriteLine("Miles per gallon : " + miles/gas + "mpg");
            Console.ReadLine();
        }
    }
}
