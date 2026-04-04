using System;

Console.WriteLine("--- Test Dzielenia ---");

try
{
    Console.WriteLine("Podaj licznik (liczba, którą dzielisz):");
    int licznik = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Podaj mianownik (liczba, przez którą dzielisz):");
    int mianownik = Convert.ToInt32(Console.ReadLine());
    
    
    int wynik = licznik / mianownik;
    
    Console.WriteLine($"\nWynik: {licznik} / {mianownik} = {wynik}");
}
catch (DivideByZeroException)
{
   
    Console.WriteLine("\n🔴 BŁĄD: Nie wolno dzielić przez zero!");
}
catch (FormatException)
{
    
    Console.WriteLine("\n🔴 BŁĄD: Wprowadzono niepoprawną liczbę!");
}

Console.WriteLine("\nProgram zakończył działanie.");