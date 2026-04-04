# Test jednostkowy dla sprawdzania liczb pierwszych

Program konsolowy w C# (.NET) z pełnym zestawem testów jednostkowych dla algorytmu sprawdzającego liczby pierwsze.

---

## Funkcjonalność

- Klasa `MatematykaPierwsza` z metodami `CzyPierwsza` i `ZnajdzPierwsze`.
- Algorytm sprawdzania optymalny do pierwiastka n (`Math.Sqrt`).
- Obsługuje liczby ujemne, 0 i 1 (zwraca false).
- Testy obejmują: liczby pierwsze, złożone, skrajne przypadki.
- Używa `[Theory]` z `[InlineData]` dla wielu przypadków testowych.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
