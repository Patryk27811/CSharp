# ShapeFactory – fabryka kształtów geometrycznych

Program konsolowy w C# (.NET) implementujący wzorzec Factory Method do tworzenia obiektów kształtów geometrycznych.

---

## Funkcjonalność

- Interfejs `IKsztalt` z właściwością `Nazwa` i metodami `Pole()`, `Obwod()`.
- Implementacje: `Okrag` (oblicza pole i obwód za pomocą Math.PI) i `Prostokat`.
- Klasa `KsztaltFactory` z metodą `Utworz` i switch expression.
- Obsługuje typy "okrag"/"circle" oraz "prostokat"/"rectangle".
- Rzuca `ArgumentException` dla nieznanych typów i nieprawidłowych wymiarów.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnie.
