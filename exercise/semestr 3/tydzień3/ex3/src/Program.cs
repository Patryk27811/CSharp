using System;

namespace ProstokatApp
{
    public class Rectangle
    {
        public double Width { get; }
        public double Height { get; }

       
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area() => Width * Height;
        public double Perimeter() => 2 * (Width + Height);
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Podaj szerokość: ");
            double width = double.Parse(Console.ReadLine()!);

            Console.Write("Podaj wysokość: ");
            double height = double.Parse(Console.ReadLine()!);

            var rect = new Rectangle(width, height);

            Console.WriteLine($"Pole: {rect.Area()}");
            Console.WriteLine($"Obwód: {rect.Perimeter()}");
        }
    }
}
