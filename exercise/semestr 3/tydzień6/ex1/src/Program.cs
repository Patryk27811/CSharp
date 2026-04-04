using System;
using System.Linq;

Console.WriteLine("--- Sprawdzanie Palindromu---");

Console.WriteLine("Podaj słowo do sprawdzenia:");
string? tekst = Console.ReadLine();

bool wynik = tekst.IsPalindrome();

if (wynik)
{
    Console.WriteLine($"Sukces: '{tekst}' jest palindromem.");
}
else
{
    Console.WriteLine($"Porażka: '{tekst}' nie jest palindromem.");
}

public static class StringExtensions
{
    public static bool IsPalindrome(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return false;
        }

        string cleanStr = str.ToLower();
        string reversed = new string(cleanStr.Reverse().ToArray());

        return cleanStr == reversed;
    }
}