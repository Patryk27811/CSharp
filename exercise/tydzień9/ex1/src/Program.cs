using System;

Console.WriteLine("--- Obliczanie Pola Koła ---");

try
{
    Console.WriteLine("Podaj promień koła:");
    double promien = Convert.ToDouble(Console.ReadLine());

    Kolo kolo = new Kolo(promien);

    Console.WriteLine($"Pole koła o promieniu {kolo.Promien} wynosi: {kolo.ObliczPole():F4}");
}
catch (FormatException)
{
    Console.WriteLine("BŁĄD: Podana wartość nie jest liczbą.");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"BŁĄD DANYCH: {ex.Message}");
}

public class Kolo
{
    public double Promien { get; }

    public Kolo(double promien)
    {
        if (promien <= 0)
        {
            throw new ArgumentException("Promień musi być większy od zera.");
        }
        Promien = promien;
    }

    public double ObliczPole()
    {
        return Math.PI * Math.Pow(Promien, 2);
    }
}