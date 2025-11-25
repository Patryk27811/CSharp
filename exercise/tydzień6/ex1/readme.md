# Program do Sprawdzania Palindromów (IsPalindrome)

Prosty program konsolowy w C#, który sprawdza, czy podany ciąg znaków jest palindromem, wykorzystując mechanizm **Metod Rozszerzających**.

---

## Funkcjonalność

Program prosi użytkownika o podanie słowa lub zdania.

- Definiuje statyczną klasę `StringExtensions` z metodą `IsPalindrome`.
- Metoda ta jest "doklejona" do typu `string?` (nullowalnego ciągu znaków).
- Logika sprawdza tekst ignorując wielkość liter (np. "Kajak" jest uznawany za palindrom).
- Wykorzystuje LINQ (`Reverse().ToArray()`) do odwrócenia ciągu znaków i porównania go z oryginałem.
- Obsługuje przypadki brzegowe, takie jak pusty tekst lub wartość `null`.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
