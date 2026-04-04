# Async: Metoda pobierająca dane z API

Program konsolowy w C# (.NET) demonstrujący podstawy programowania asynchronicznego – metoda async/await symulująca pobieranie danych z API.

---

## Funkcjonalność

- Klasa `ApiKlient` z metodą `PobierzDaneAsync` zwracającą `Task<string>`.
- Symuluje opóźnienie sieciowe za pomocą `Task.Delay`.
- Rzuca `ArgumentException` dla pustego URL.
- Wynik wyświetlany jest w konsoli po zakończeniu operacji.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
