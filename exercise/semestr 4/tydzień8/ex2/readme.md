# OrderService: Sumowanie wartości zamówienia

Program konsolowy w C# (.NET) implementujący serwis do obliczania wartości zamówień z obsługą rabatów.

---

## Funkcjonalność

- Rekordy `PozycjaZamowienia` i `Zamowienie` reprezentują model danych.
- Klasa `OrderService` z metodami `ObliczWartosc` i `ObliczZRabatem`.
- Sumuje wartości pozycji jako `Cena * Ilosc`.
- Obsługuje rabat procentowy w zakresie 0-100%.
- Waliduje wejście i rzuca odpowiednie wyjątki.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnie.
