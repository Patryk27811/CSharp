# Program do Obsługi Wyjątków (try-catch)

Prosty program konsolowy w C#, który demonstruje, jak poprawnie obsługiwać błędy (wyjątki) przyjmowane od użytkownika.

---

## Funkcjonalność

Program prosi użytkownika o podanie dwóch liczb (licznika i mianownika), a następnie próbuje je podzielić.

- Poprawne dane: Wyświetla wynik dzielenia (np. `10 / 2 = 5`).
- Błąd `FormatException`: Gdy użytkownik zamiast liczby wpisze tekst (np. "abc"), program łapie błąd i wyświetla komunikat `BŁĄD: Wprowadzono niepoprawną liczbę!`.
- łąd `DivideByZeroException`: Gdy użytkownik jako mianownik poda `0`, program łapie błąd i wyświetla komunikat `BŁĄD: Nie wolno dzielić przez zero!`.

Program nie zawiesza się po wystąpieniu błędu i bezpiecznie kończy działanie.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
