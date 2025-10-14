Console.Write("Jak masz na imię? ");
string? imie = Console.ReadLine();

if (string.IsNullOrWhiteSpace(imie))
{
    Console.WriteLine("Nie podałeś imienia");
}
else
{
    Console.WriteLine($"Witaj, {imie}!");
}
