# ToDo: Konsolowa lista zadań z zapisem JSON

Program konsolowy w C# (.NET) – prosta lista zadań do zrobienia z możliwością zapisu i odczytu z pliku JSON.

---

## Funkcjonalność

- Rekord `TodoItem` z polami: `Id`, `Tytul`, `Ukonczone`, `Utworzono`.
- Klasa `TodoManager` z metodami `Dodaj` i `Ukoncz` (zmienia status bez modyfikacji rekordu – `with`).
- Klasa `TodoStorage` serializuje i deserializuje listę do/z pliku JSON.
- Waliduje tytuł – rzuca `ArgumentException` dla pustego stringa.
- Wyświetla listę z oznaczeniem ukończonych zadań.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
