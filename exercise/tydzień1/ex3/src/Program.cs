
using System;

public class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int liczba))
        {
            if (CzyParzysta(liczba))
                Console.WriteLine("Liczba jest parzysta.");
            else
                Console.WriteLine("Liczba jest nieparzysta.");
        }
        else
        {
            Console.WriteLine("Niepoprawny format liczby!");
        }
    }

    
    public static bool CzyParzysta(int liczba)
    {
        return liczba % 2 == 0;
    }
}
