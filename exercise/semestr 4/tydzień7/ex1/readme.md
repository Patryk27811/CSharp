# Sumowanie liczb z pliku tekstowego

Program konsolowy w C# (.NET), który odczytuje plik tekstowy i sumuje wszystkie liczby w nim zawarte.

---

## Funkcjonalność

- Klasa `SumatorPliku` z metodą `SumujLiczbyZPliku`.
- Czyta plik linia po linii za pomocą `File.ReadLines` (wydajne dla dużych plików).
- Parsuje każdą linię – pomija nieparsowalne wartości (np. tekst, puste linie).
- Rzuca `FileNotFoundException` gdy plik nie istnieje.
- Zwraca sumę jako `long` (obsługa dużych wartości).

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
