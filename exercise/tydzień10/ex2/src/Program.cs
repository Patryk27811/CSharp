using System;

Console.WriteLine("--- Dni Tygodnia (Enum) ---");

Console.WriteLine("Podaj numer dnia tygodnia (1-7):");
string? wejscie = Console.ReadLine();

if (int.TryParse(wejscie, out int numer))
{
    if (Enum.IsDefined(typeof(DzienTygodnia), numer))
    {
        DzienTygodnia dzien = (DzienTygodnia)numer;
        
        string typDnia = Kalendarz.CzyWeekend(dzien) ? "Weekend" : "Dzień roboczy";

        Console.WriteLine($"\nWybrano: {dzien}");
        Console.WriteLine($"Numer: {(int)dzien}");
        Console.WriteLine($"Typ: {typDnia}");
    }
    else
    {
        Console.WriteLine("BŁĄD: Podano numer spoza zakresu 1-7.");
    }
}
else
{
    Console.WriteLine("BŁĄD: Wprowadzono niepoprawną liczbę.");
}

public enum DzienTygodnia
{
    Poniedzialek = 1,
    Wtorek,
    Sroda,
    Czwartek,
    Piatek,
    Sobota,
    Niedziela
}

public static class Kalendarz
{
    public static bool CzyWeekend(DzienTygodnia dzien)
    {
        return dzien == DzienTygodnia.Sobota || dzien == DzienTygodnia.Niedziela;
    }
}