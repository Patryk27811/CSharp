using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("--- Dziennik Ocen ---");

Dziennik dziennik = new Dziennik();

try
{
    dziennik.DodajOcene("Matematyka", 5);
    dziennik.DodajOcene("Język Polski", 4);
    dziennik.DodajOcene("Angielski", 6);
    
    dziennik.DodajOcene("Matematyka", 4); 

    dziennik.WypiszOceny();

    Console.WriteLine($"\nŚrednia ocen: {dziennik.ObliczSrednia():F2}");

    Console.WriteLine("\nPróba dodania błędnej oceny:");
    dziennik.DodajOcene("WF", 7);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"BŁĄD: {ex.Message}");
}

public class Dziennik
{
    private Dictionary<string, int> _oceny = new Dictionary<string, int>();

    public void DodajOcene(string przedmiot, int ocena)
    {
        if (string.IsNullOrWhiteSpace(przedmiot))
        {
            throw new ArgumentException("Nazwa przedmiotu nie może być pusta.");
        }
        if (ocena < 1 || ocena > 6)
        {
            throw new ArgumentException($"Ocena {ocena} jest nieprawidłowa. Skala 1-6.");
        }

        if (_oceny.ContainsKey(przedmiot))
        {
            Console.WriteLine($"[Info] Aktualizacja oceny z {_oceny[przedmiot]} na {ocena} dla: {przedmiot}");
            _oceny[przedmiot] = ocena;
        }
        else
        {
            _oceny.Add(przedmiot, ocena);
        }
    }

    public int PobierzOcene(string przedmiot)
    {
        if (_oceny.TryGetValue(przedmiot, out int ocena))
        {
            return ocena;
        }
        throw new KeyNotFoundException($"Nie znaleziono przedmiotu: {przedmiot}");
    }

    public double ObliczSrednia()
    {
        if (_oceny.Count == 0)
        {
            return 0.0;
        }
        return _oceny.Values.Average();
    }

    public void WypiszOceny()
    {
        Console.WriteLine("\nLista przedmiotów i ocen:");
        foreach (var wpis in _oceny)
        {
            Console.WriteLine($"- {wpis.Key}: {wpis.Value}");
        }
    }
}