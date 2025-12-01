using System;
using System.Collections.Generic;

Console.WriteLine("--- Weryfikator Nawiasów ---");

Console.WriteLine("Podaj ciąg znaków do sprawdzenia:");
string wejscie = Console.ReadLine() ?? string.Empty;

bool czyPoprawne = WeryfikatorNawiasow.Sprawdz(wejscie);

if (czyPoprawne)
{
    Console.WriteLine("✅ Ciąg posiada poprawną strukturę nawiasów.");
}
else
{
    Console.WriteLine("❌ Błąd: Struktura nawiasów jest niepoprawna.");
}

public static class WeryfikatorNawiasow
{
    public static bool Sprawdz(string tekst)
    {
        if (string.IsNullOrEmpty(tekst))
        {
            return true;
        }

        Stack<char> stos = new Stack<char>();

        foreach (char znak in tekst)
        {
            if (znak == '(' || znak == '[' || znak == '{')
            {
                stos.Push(znak);
            }
            else if (znak == ')' || znak == ']' || znak == '}')
            {
                if (stos.Count == 0)
                {
                    return false;
                }

                char otwarcie = stos.Pop();

                if (!CzyPasuje(otwarcie, znak))
                {
                    return false;
                }
            }
        }

        return stos.Count == 0;
    }

    private static bool CzyPasuje(char otwarcie, char zamkniecie)
    {
        return (otwarcie == '(' && zamkniecie == ')') ||
               (otwarcie == '[' && zamkniecie == ']') ||
               (otwarcie == '{' && zamkniecie == '}');
    }
}