using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = double.Parse(Console.ReadLine());

        double suma = a + b;
        double roznica = a - b;
        double iloczyn = a * b;
        double iloraz = b != 0 ? a / b : double.NaN;

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Różnica: {roznica}");
        Console.WriteLine($"Iloczyn: {iloczyn}");
        Console.WriteLine($"Iloraz: {(b != 0 ? iloraz.ToString() : "Nie można dzielić przez zero")}");
    }
}