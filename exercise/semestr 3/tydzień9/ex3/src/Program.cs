using System;

Console.WriteLine("--- Przeciążanie Operatora + (Wektor2D) ---");

Wektor2D wektor1 = new Wektor2D(3.0, 5.0);
Wektor2D wektor2 = new Wektor2D(2.0, -1.0);

Console.WriteLine($"Wektor 1: {wektor1}");
Console.WriteLine($"Wektor 2: {wektor2}");

Wektor2D suma = wektor1 + wektor2;

Console.WriteLine($"\nWynik dodawania (W1 + W2): {suma}");

Wektor2D wektor3 = new Wektor2D(10.0, 10.0);
Wektor2D sumaPotrojna = wektor1 + wektor2 + wektor3;

Console.WriteLine($"Wynik dodawania trzech wektorów: {sumaPotrojna}");

public class Wektor2D
{
    public double X { get; }
    public double Y { get; }

    public Wektor2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Wektor2D operator +(Wektor2D a, Wektor2D b)
    {
        return new Wektor2D(a.X + b.X, a.Y + b.Y);
    }

    public override string ToString()
    {
        return $"[{X}, {Y}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Wektor2D other)
        {
            return X == other.X && Y == other.Y;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}