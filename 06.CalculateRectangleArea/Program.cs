using System;

namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var area = Area(width, height);

            Console.WriteLine(area) ;
        }

        static double Area(double width, double height)
        {
            return width * height;
        }
    }
}