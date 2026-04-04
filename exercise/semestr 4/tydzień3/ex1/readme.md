# Zliczanie częstości słów w tekście

Program konsolowy w C# (.NET), który analizuje tekst i zlicza ile razy każde słowo w nim występuje.

---

## Funkcjonalność

- Klasa `AnalizatorSlow` z metodą `ZliczSlowa` analizuje podany tekst.
- Dzieli tekst na słowa po separatorach (spacja, znaki interpunkcji, nowe linie).
- Ignoruje wielkość liter (normalizuje do małych).
- Zwraca słownik `Dictionary<string, int>` z częstościami.
- Dla pustego tekstu zwraca pusty słownik.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
