using System;

Console.WriteLine("--- Symulator Samochodu ---");

Samochod auto = new Samochod("Toyota Corolla", 50.0, 6.5);

Console.WriteLine($"Samochód: {auto.Model}");
Console.WriteLine($"Paliwo startowe: {auto.Paliwo:F2} litrów");
Console.WriteLine($"Spalanie: {auto.SpalanieNa100Km} L/100km");

try
{
    Console.WriteLine("\nPodaj dystans do przejechania (km):");
    double dystans = Convert.ToDouble(Console.ReadLine());

    auto.Jedz(dystans);

    Console.WriteLine($"\nPrzejechałeś {dystans} km.");
    Console.WriteLine($"Pozostałe paliwo: {auto.Paliwo:F2} litrów");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"\n⛔ NIE MOŻNA JECHAĆ: {ex.Message}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\nBŁĄD DANYCH: {ex.Message}");
}
catch (FormatException)
{
    Console.WriteLine("\nBŁĄD: Wpisz poprawną liczbę.");
}

public class Samochod
{
    public string Model { get; }
    public double Paliwo { get; private set; }
    public double SpalanieNa100Km { get; }

    public Samochod(string model, double paliwo, double spalanieNa100Km)
    {
        if (string.IsNullOrWhiteSpace(model))
            throw new ArgumentException("Model nie może być pusty.");
        if (paliwo < 0)
            throw new ArgumentException("Paliwo nie może być ujemne.");
        if (spalanieNa100Km <= 0)
            throw new ArgumentException("Spalanie musi być dodatnie.");

        Model = model;
        Paliwo = paliwo;
        SpalanieNa100Km = spalanieNa100Km;
    }

    public void Jedz(double km)
    {
        if (km <= 0)
        {
            throw new ArgumentException("Dystans musi być dodatni.");
        }

        double potrzebnePaliwo = (km / 100.0) * SpalanieNa100Km;

        if (potrzebnePaliwo > Paliwo)
        {
            throw new InvalidOperationException($"Za mało paliwa. Potrzebujesz {potrzebnePaliwo:F2} L, a masz {Paliwo:F2} L.");
        }

        Paliwo -= potrzebnePaliwo;
    }
}