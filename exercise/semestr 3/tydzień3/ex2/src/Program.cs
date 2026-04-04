using System;

namespace ProstokatApp
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

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
                if (!double.TryParse(Console.ReadLine(), out double width))
                {
                 Console.WriteLine("Nieprawidłowa liczba!");
                    return;
                }

                Console.Write("Podaj wysokość: ");
                if (!double.TryParse(Console.ReadLine(), out double height))
                {
                    Console.WriteLine("Nieprawidłowa liczba!");
                    return;
                }

            var rect = new Rectangle(width, height);

            Console.WriteLine($"Pole: {rect.Area()}");
            Console.WriteLine($"Obwód: {rect.Perimeter()}");
        }
    }
}
