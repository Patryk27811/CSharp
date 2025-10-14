using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Prosty kalkulator ===");

        // Wczytaj pierwszą liczbę
        double a = ReadNumber("Podaj pierwszą liczbę: ");

        // Wczytaj drugą liczbę
        double b = ReadNumber("Podaj drugą liczbę: ");

        // Obliczenia
        double suma = a + b;
        double roznica = a - b;
        double iloczyn = a * b;
        string iloraz = (b != 0) ? (a / b).ToString(CultureInfo.InvariantCulture) : "Nie można dzielić przez zero";

        // Wyniki
        Console.WriteLine();
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Różnica: {roznica}");
        Console.WriteLine($"Iloczyn: {iloczyn}");
        Console.WriteLine($"Iloraz: {iloraz}");
    }

    static double ReadNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine()!;

            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Nie wpisano liczby, spróbuj ponownie.");
                continue;
            }

            
            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Błąd: używaj kropki zamiast przecinka (np. 3.14). Spróbuj ponownie.");
            }
        }
    }
}
