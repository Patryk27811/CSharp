# Async: 5 równoległych żądań HTTP

Program konsolowy w C# (.NET) demonstrujący równoległe wykonywanie operacji asynchronicznych za pomocą `Task.WhenAll`.

---

## Funkcjonalność

- Klasa `RownoleglePobieranie` z metodą `PobierzRownolegleAsync`.
- Przyjmuje listę URL-i i uruchamia wszystkie żądania równolegle.
- Używa `Task.WhenAll` do oczekiwania na wszystkie wyniki jednocześnie.
- Rzuca `ArgumentException` dla pustej lub null listy.
- Wyświetla wszystkie wyniki po zakończeniu.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnie.
