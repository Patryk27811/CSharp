using System;
using System.Collections.Generic;
using Geometry;

Console.WriteLine("--- Demonstracja Interfejsów  ---");

List<IShape> shapes = new List<IShape>();

try
{
    shapes.Add(new Circle(5.0));
    shapes.Add(new Rectangle(4.0, 6.0));
    shapes.Add(new Circle(1.5));
    shapes.Add(new Rectangle(10.0, 2.0));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Błąd przy tworzeniu obiektu: {ex.Message}");
}

Console.WriteLine("\n--- Obliczanie pól i obwodów ---");

foreach (IShape shape in shapes)
{
    Console.WriteLine($"Kształt: {shape.Name}");
    Console.WriteLine($"  Pole powierzchni: {shape.Area:F2}");
    Console.WriteLine($"  Obwód: {shape.Perimeter:F2}");
    Console.WriteLine("-----------------");
}

namespace Geometry
{
    public interface IShape
    {
        string Name { get; }
        double Area { get; }
        double Perimeter { get; }
    }

    public class Circle : IShape
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Promień (Radius) musi być liczbą dodatnią.");
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public string Name => "Koło";
        public double Area => Math.PI * Radius * Radius;
        public double Perimeter => 2 * Math.PI * Radius;
    }

    public class Rectangle : IShape
    {
        private double _width;
        private double _height;

        public double Width
        {
            get => _width;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Szerokość (Width) musi być liczbą dodatnią.");
                _width = value;
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Wysokość (Height) musi być liczbą dodatnią.");
                _height = value;
            }
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public string Name => "Prostokąt";
        public double Area => Width * Height;
        public double Perimeter => (2 * Width) + (2 * Height);
    }
}
