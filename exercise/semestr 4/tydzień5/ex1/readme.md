# Task.Delay i logowanie czasu wykonania

Program konsolowy w C# (.NET) mierzący czas wykonania operacji asynchronicznej za pomocą `Task.Delay`.

---

## Funkcjonalność

- Klasa `Stoper` z metodą `ZmierzCzasAsync` przyjmującą `Func<Task>`.
- Mierzy czas od startu do zakończenia przekazanej operacji.
- Zwraca `TimeSpan` z czasem wykonania.
- Rzuca `ArgumentNullException` gdy operacja to null.
- Wyświetla czas w milisekundach.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
