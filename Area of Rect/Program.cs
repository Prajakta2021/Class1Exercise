using System;

namespace Area_of_Rect
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            string inputX;
            string inputY;

            Console.WriteLine("Enter length of rectangle: ");
            inputX = Console.ReadLine();
            x = double.Parse(inputX);

            Console.WriteLine("Enter width of rectangle: ");
           inputY = Console.ReadLine();
            y = double.Parse(inputY);

            Console.WriteLine("Area of rectangle : " + x * y);
            Console.ReadLine();
        }
    }
}
