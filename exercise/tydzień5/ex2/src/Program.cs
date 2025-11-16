using System;
User uzytkownik = new User();

try
{
    Console.WriteLine("Podaj imię użytkownika:");
    uzytkownik.Name = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("Podaj wiek użytkownika:");
    int wiek = Convert.ToInt32(Console.ReadLine());
    
    uzytkownik.Age = wiek;

    Console.WriteLine("\n--- SUKCES ---");
    Console.WriteLine($"Utworzono użytkownika: {uzytkownik.Name}, Wiek: {uzytkownik.Age}");
}
catch (InvalidAgeException ex)
{
    Console.WriteLine("\n🔴 BŁĄD REJESTRACJI: Podano niepoprawny wiek.");
    Console.WriteLine(ex.Message);
}
catch (FormatException)
{
    Console.WriteLine("\n🔴 BŁĄD WPISYWANIA: Podana wartość nie była poprawną liczbą!");
}
catch (Exception ex)
{
    Console.WriteLine($"\nInny, nieoczekiwany błąd: {ex.Message}");
}

Console.WriteLine("\nProgram zakończył działanie.");

public class User
{
    private int _age;
    
    public string Name { get; set; } = string.Empty;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0 || value > 120)
            {
                throw new InvalidAgeException(value);
            }
            _age = value;
        }
    }
}

public class InvalidAgeException : Exception
{
    public int InvalidAge { get; }

    public InvalidAgeException() 
        : base("Podano nieprawidłowy wiek.") 
    { }

    public InvalidAgeException(string message) 
        : base(message) 
    { }

    public InvalidAgeException(int invalidAge)
        : base($"Błędny wiek: {invalidAge}. Wiek musi być w zakresie 0-120.")
    {
        InvalidAge = invalidAge;
    }

    public InvalidAgeException(string message, Exception inner) 
        : base(message, inner) 
    { }
}