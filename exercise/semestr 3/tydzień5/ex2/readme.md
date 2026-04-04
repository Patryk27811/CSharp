# Program Rejestracji Użytkownika (Własny Wyjątek)

Prosty program konsolowy w C#, który demonstruje tworzenie i obsługę niestandardowych wyjątków (`InvalidAgeException`).

---

## Funkcjonalność

Program prosi użytkownika o podanie imienia oraz wieku.

- Definiuje własną klasę wyjątku `InvalidAgeException`, która dziedziczy po `Exception`.
- Posiada klasę `User` z walidacją właściwości `Age`.
- Jeśli wiek jest poza zakresem (0-120), klasa `User` rzuca wyjątek `InvalidAgeException`.
- Główny program używa bloku `try...catch` do łapania błędów `InvalidAgeException` (błędna logika) oraz `FormatException` (błędny format liczby).
- Program nie zawiesza się po wystąpieniu błędu.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnio trudne.
