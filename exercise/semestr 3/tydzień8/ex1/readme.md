# Weryfikator Nawiasów

Program w C# służący do sprawdzania poprawności zagnieżdżenia nawiasów w ciągu znaków, wykorzystujący strukturę danych **Stos (Stack)**.

---

## Funkcjonalność

Program prosi użytkownika o podanie dowolnego tekstu (np. wyrażenia matematycznego).

- Obsługuje trzy rodzaje nawiasów: `()`, `[]`, `{}`.
- Ignoruje inne znaki (litery, cyfry, operatory).
- **Algorytm:**
  - Nawias otwierający jest odkładany na stos.
  - Nawias zamykający zdejmuje element ze stosu i sprawdza, czy tworzy z nim poparwną parę.
  - Jeśli stos jest pusty przed końcem sprawdzania (nadmiarowy nawias zamykający) lub niepusty po zakończeniu (niezamknięty nawias otwierający), ciąg jest uznawany za błędny.
- Zwraca `true` dla poprawnych ciągów (np. `{[()]}`) i `false` dla błędnych (np. `([)]`).

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe
