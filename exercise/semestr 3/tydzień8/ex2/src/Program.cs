using System;
using System.Collections.Generic;

Console.WriteLine("--- Kalkulator RPN (Odwrotna Notacja Polska) ---");
Console.WriteLine("Podaj wyrażenie RPN (np. '3 4 + 2'):");
Console.WriteLine("Dozwolone operatory: + - * /");

string wejscie = Console.ReadLine() ?? string.Empty;

try
{
    double wynik = KalkulatorRPN.Oblicz(wejscie);
    Console.WriteLine($"\nWynik: {wynik}");
}
catch (Exception ex)
{
    Console.WriteLine($"\nBŁĄD: {ex.Message}");
}

public static class KalkulatorRPN
{
    public static double Oblicz(string wyrazenie)
    {
        if (string.IsNullOrWhiteSpace(wyrazenie))
        {
            throw new ArgumentException("Wyrażenie nie może być puste.");
        }

        Stack<double> stos = new Stack<double>();
        string[] tokeny = wyrazenie.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokeny)
        {
            if (double.TryParse(token, out double liczba))
            {
                stos.Push(liczba);
            }
            else
            {
                if (stos.Count < 2)
                {
                    throw new InvalidOperationException("Nieprawidłowa struktura wyrażenia (za mało liczb).");
                }

                double b = stos.Pop();
                double a = stos.Pop();
                double wynikOperacji = WykonajOperacje(a, b, token);
                stos.Push(wynikOperacji);
            }
        }

        if (stos.Count != 1)
        {
            throw new InvalidOperationException("Nieprawidłowa struktura wyrażenia (za dużo liczb na końcu).");
        }

        return stos.Pop();
    }

    private static double WykonajOperacje(double a, double b, string operatorTekstowy)
    {
        return operatorTekstowy switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b == 0 ? throw new DivideByZeroException("Dzielenie przez zero.") : a / b,
            _ => throw new ArgumentException($"Nieznany operator: {operatorTekstowy}")
        };
    }
}