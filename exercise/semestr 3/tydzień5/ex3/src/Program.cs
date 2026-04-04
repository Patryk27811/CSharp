using System;

Console.WriteLine("--- Odwracanie Ciągu Znaków ---");

Console.WriteLine("Podaj tekst do odwrócenia:");
string tekst = Console.ReadLine() ?? string.Empty;

string odwroconyTekst = ReverseString(tekst);

Console.WriteLine($"Odwórcony tekst: {odwroconyTekst}");


string ReverseString(string s)
{
    if (string.IsNullOrEmpty(s))
    {
        return s;
    }

    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}