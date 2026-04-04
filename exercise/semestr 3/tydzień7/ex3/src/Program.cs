using System;

Console.WriteLine("--- Gra Zgadnij Liczbę (1-100) ---");

int wylosowanaLiczba = new Random().Next(1, 101);
bool odgadnieto = false;
int licznikProb = 0;

Console.WriteLine("Wylosowałem liczbę od 1 do 100. Spróbuj ją zgadnąć!");

while (!odgadnieto)
{
    Console.Write("Podaj swoją propozycję: ");
    string? wejscie = Console.ReadLine();

    if (int.TryParse(wejscie, out int strzal))
    {
        licznikProb++;
        WynikStrzalu wynik = LogikaGry.Sprawdz(strzal, wylosowanaLiczba);

        if (wynik == WynikStrzalu.ZaMalo)
        {
            Console.WriteLine("Za mało! Spróbuj wyżej.");
        }
        else if (wynik == WynikStrzalu.ZaDuzo)
        {
            Console.WriteLine("Za dużo! Spróbuj niżej.");
        }
        else
        {
            Console.WriteLine($"\nBRAWO! Trafiłeś liczbę {wylosowanaLiczba} w {licznikProb} próbach.");
            odgadnieto = true;
        }
    }
    else
    {
        Console.WriteLine("Błąd: Proszę podać poprawną liczbę całkowitą.");
    }
}

public enum WynikStrzalu
{
    ZaMalo,
    ZaDuzo,
    Trafiony
}

public static class LogikaGry
{
    public static WynikStrzalu Sprawdz(int strzal, int cel)
    {
        if (strzal < cel)
        {
            return WynikStrzalu.ZaMalo;
        }
        else if (strzal > cel)
        {
            return WynikStrzalu.ZaDuzo;
        }
        else
        {
            return WynikStrzalu.Trafiony;
        }
    }
}