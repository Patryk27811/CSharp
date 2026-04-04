# Async: Obsługa wyjątków w await

Program konsolowy w C# (.NET) demonstrujący zaawansowaną obsługę wyjątków w metodach asynchronicznych.

---

## Funkcjonalność

- Definiuje niestandardowy wyjątek `BladApiException` z właściwością `KodStatusu`.
- Klasa `BezpiecznyKlient` z metodą `PobierzBezpiecznieAsync` rzucającą wyjątek przy symulowanym błędzie.
- Metoda `PobierzZObslugaBledow` opakowuje wywołanie w try-catch.
- Przechwytuje `BladApiException` i zwraca opisowy komunikat zamiast propagacji wyjątku.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
