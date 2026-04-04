using System;

Console.WriteLine("--- Mini-Projekt: Kalkulator CLI ---");

bool czyKontynuowac = true;

while (czyKontynuowac)
{
    WyswietlMenu();
    string? wybor = Console.ReadLine();

    if (wybor == "0")
    {
        czyKontynuowac = false;
        Console.WriteLine("Do widzenia!");
        continue;
    }

    try
    {
        double a = PobierzLiczbe("Podaj pierwszą liczbę: ");
        double b = PobierzLiczbe("Podaj drugą liczbę: ");
        double wynik = 0;

        switch (wybor)
        {
            case "1":
                wynik = Kalkulator.Dodaj(a, b);
                Console.WriteLine($"\n✅ Wynik: {a} + {b} = {wynik}");
                break;
            case "2":
                wynik = Kalkulator.Odejmij(a, b);
                Console.WriteLine($"\n✅ Wynik: {a} - {b} = {wynik}");
                break;
            case "3":
                wynik = Kalkulator.Mnoz(a, b);
                Console.WriteLine($"\n✅ Wynik: {a} * {b} = {wynik}");
                break;
            case "4":
                wynik = Kalkulator.Dziel(a, b);
                Console.WriteLine($"\n✅ Wynik: {a} / {b} = {wynik}");
                break;
            case "5":
                wynik = Kalkulator.Poteguj(a, b);
                Console.WriteLine($"\n✅ Wynik: {a} ^ {b} = {wynik}");
                break;
            default:
                Console.WriteLine("\n⚠️ Nieznana opcja. Wybierz ponownie.");
                break;
        }
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("\n⛔ BŁĄD: Nie można dzielić przez zero!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n⛔ BŁĄD: {ex.Message}");
    }

    Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
    Console.ReadKey();
    Console.Clear();
}

static void WyswietlMenu()
{
    Console.WriteLine("Wybierz działanie:");
    Console.WriteLine("1. Dodawanie (+)");
    Console.WriteLine("2. Odejmowanie (-)");
    Console.WriteLine("3. Mnożenie (*)");
    Console.WriteLine("4. Dzielenie (/)");
    Console.WriteLine("5. Potęgowanie (^)");
    Console.WriteLine("0. Wyjście");
    Console.Write("\nTwój wybór: ");
}

static double PobierzLiczbe(string komunikat)
{
    while (true)
    {
        Console.Write(komunikat);
        if (double.TryParse(Console.ReadLine(), out double liczba))
        {
            return liczba;
        }
        Console.WriteLine("To nie jest liczba. Spróbuj ponownie.");
    }
}

public static class Kalkulator
{
    public static double Dodaj(double a, double b) => a + b;

    public static double Odejmij(double a, double b) => a - b;

    public static double Mnoz(double a, double b) => a * b;

    public static double Dziel(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Mianownik nie może być zerem.");
        }
        return a / b;
    }

    public static double Poteguj(double podstawa, double wykladnik)
    {
        return Math.Pow(podstawa, wykladnik);
    }
}