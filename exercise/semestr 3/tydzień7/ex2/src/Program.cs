using System;
using System.IO;
using System.Linq;

Console.WriteLine("--- Licznik Statystyk Pliku ---");

Console.WriteLine("Podaj ścieżkę do pliku tekstowego:");
string sciezka = Console.ReadLine() ?? string.Empty;

if (File.Exists(sciezka))
{
    string tresc = File.ReadAllText(sciezka);
    
    WynikiStatystyk wyniki = AnalizatorTekstu.Analizuj(tresc);

    Console.WriteLine($"\n--- Wyniki dla pliku: {Path.GetFileName(sciezka)} ---");
    Console.WriteLine($"Liczba znaków: {wyniki.LiczbaZnakow}");
    Console.WriteLine($"Liczba słów:   {wyniki.LiczbaSlow}");
    Console.WriteLine($"Liczba linii:  {wyniki.LiczbaLinii}");
}
else
{
    Console.WriteLine($"\nBŁĄD: Plik nie istnieje: {sciezka}");
}

public record WynikiStatystyk(int LiczbaZnakow, int LiczbaSlow, int LiczbaLinii);

public static class AnalizatorTekstu
{
    public static WynikiStatystyk Analizuj(string tekst)
    {
        if (string.IsNullOrEmpty(tekst))
        {
            return new WynikiStatystyk(0, 0, 0);
        }

        int znaki = tekst.Length;

        string[] slowaTablica = tekst.Split(
            new char[] { ' ', '\r', '\n', '\t' }, 
            StringSplitOptions.RemoveEmptyEntries
        );
        int slowa = slowaTablica.Length;

        int linie = tekst.Split('\n').Length;

        return new WynikiStatystyk(znaki, slowa, linie);
    }
}