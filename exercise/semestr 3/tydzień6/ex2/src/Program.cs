using System;

Console.WriteLine("--- Symulacja Konta Bankowego ---");

KontoBankowe mojeKonto = new KontoBankowe("Jan Kowalski", 100m);
Console.WriteLine($"Utworzono konto. Właściciel: {mojeKonto.Wlasciciel}, Saldo początkowe: {mojeKonto.Saldo} PLN");

try
{
    Console.WriteLine("\nPodaj kwotę do wpłaty:");
    decimal kwotaWplaty = Convert.ToDecimal(Console.ReadLine());
    mojeKonto.Wplac(kwotaWplaty);
    Console.WriteLine($"Wpłacono środki. Aktualne saldo: {mojeKonto.Saldo} PLN");

    Console.WriteLine("\nPodaj kwotę do wypłaty:");
    decimal kwotaWyplaty = Convert.ToDecimal(Console.ReadLine());
    mojeKonto.Wyplac(kwotaWyplaty);
    Console.WriteLine($"Wypłacono środki. Aktualne saldo: {mojeKonto.Saldo} PLN");
}
catch (Exception ex)
{
    Console.WriteLine($"\n🔴 BŁĄD: {ex.Message}");
}

Console.WriteLine($"\nKońcowe saldo: {mojeKonto.Saldo} PLN");

public class KontoBankowe
{
    public string Wlasciciel { get; }
    public decimal Saldo { get; private set; }

    public KontoBankowe(string wlasciciel, decimal saldoPoczatkowe = 0)
    {
        if (string.IsNullOrWhiteSpace(wlasciciel))
        {
            throw new ArgumentException("Nazwa właściciela nie może być pusta.");
        }
        if (saldoPoczatkowe < 0)
        {
            throw new ArgumentException("Saldo początkowe nie może być ujemne.");
        }

        Wlasciciel = wlasciciel;
        Saldo = saldoPoczatkowe;
    }

    public void Wplac(decimal kwota)
    {
        if (kwota <= 0)
        {
            throw new ArgumentException("Kwota wpłaty musi być większa od zera.");
        }
        Saldo += kwota;
    }

    public void Wyplac(decimal kwota)
    {
        if (kwota <= 0)
        {
            throw new ArgumentException("Kwota wypłaty musi być większa od zera.");
        }
        if (kwota > Saldo)
        {
            throw new InvalidOperationException("Niewystarczające środki na koncie.");
        }
        Saldo -= kwota;
    }
}