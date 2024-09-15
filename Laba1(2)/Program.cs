using System;

namespace Laba1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны A:");
            double sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину стороны B:");
            double sideB = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(sideA, sideB);

            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
        }
    }
}