using System;

Console.WriteLine("--- Konwerter Temperatur ---");
Console.WriteLine("Wybierz opcję:");
Console.WriteLine("1. Celsjusz -> Fahrenheit");
Console.WriteLine("2. Fahrenheit -> Celsjusz");

string? wybor = Console.ReadLine();

try
{
    Console.WriteLine("Podaj temperaturę:");
    double temperatura = Convert.ToDouble(Console.ReadLine());
    double wynik = 0;

    switch (wybor)
    {
        case "1":
            wynik = Konwerter.CelsjuszNaFahrenheit(temperatura);
            Console.WriteLine($"{temperatura} °C = {wynik:F2} °F");
            break;
        case "2":
            wynik = Konwerter.FahrenheitNaCelsjusz(temperatura);
            Console.WriteLine($"{temperatura} °F = {wynik:F2} °C");
            break;
        default:
            Console.WriteLine("BŁĄD: Niepoprawny wybór opcji.");
            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("BŁĄD: Wprowadzono niepoprawną liczbę.");
}

public static class Konwerter
{
    public static double CelsjuszNaFahrenheit(double c)
    {
        return (c * 9.0 / 5.0) + 32;
    }

    public static double FahrenheitNaCelsjusz(double f)
    {
        return (f - 32) * 5.0 / 9.0;
    }
}