# Program: Sprawdzenie parzystości liczby (C#)

Ten prosty program w języku **C#** sprawdza, czy podana przez użytkownika liczba jest **parzysta** czy **nieparzysta**.  
Został napisany w formie aplikacji konsolowej i pokazuje, jak korzystać z wejścia (`Console.ReadLine`) oraz instrukcji warunkowych `if / else`.

---

## Funkcjonalność programu

Program:

1. Prosi użytkownika o podanie liczby całkowitej.
2. Sprawdza, czy liczba jest parzysta (`n % 2 == 0`).
3. Wyświetla odpowiedni komunikat:
   - `"Liczba jest parzysta."`
   - `"Liczba jest nieparzysta."`
4. Obsługuje błędne dane wejściowe (np. tekst zamiast liczby).

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj
