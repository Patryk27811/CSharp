# Logger: Zapisywanie logów do pliku

Program konsolowy w C# (.NET) implementujący logger zapisujący komunikaty do pliku tekstowego z poziomami logowania.

---

## Funkcjonalność

- Klasa `FileLogger` implementująca `IDisposable` do zarządzania zasobami.
- Enum `PoziomLogu` z wartościami: Info, Ostrzezenie, Blad.
- Każdy wpis zawiera datę, godzinę, poziom i komunikat.
- Tryb dołączania (`append: true`) – nie nadpisuje istniejących logów.
- Poprawne zwalnianie `StreamWriter` przez `Dispose`.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
