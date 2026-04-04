using System;

Console.WriteLine("--- Walidacja Wypłaty ---");

KontoBankowe konto = new KontoBankowe("Jan Nowak", 100m);
Console.WriteLine($"Saldo początkowe: {konto.Saldo} PLN");

try
{
    Console.WriteLine("Podaj kwotę do wypłaty:");
    decimal kwota = Convert.ToDecimal(Console.ReadLine());

    konto.Wyplac(kwota);
    
    Console.WriteLine($"Sukces! Nowe saldo: {konto.Saldo} PLN");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"\n ODMOWA WYPŁATY: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"\nBłąd: {ex.Message}");
}

public class KontoBankowe
{
    public string Wlasciciel { get; }
    public decimal Saldo { get; private set; }

    public KontoBankowe(string wlasciciel, decimal saldoPoczatkowe)
    {
        Wlasciciel = wlasciciel;
        Saldo = saldoPoczatkowe;
    }

    public void Wplac(decimal kwota)
    {
        if (kwota <= 0)
        {
            throw new ArgumentException("Kwota musi być dodatnia.");
        }
        Saldo += kwota;
    }

    public void Wyplac(decimal kwota)
    {
        if (kwota <= 0)
        {
            throw new ArgumentException("Kwota musi być dodatnia.");
        }

        if (kwota > Saldo)
        {
            throw new InvalidOperationException("Brak wystarczających środków na koncie.");
        }

        Saldo -= kwota;
    }
}