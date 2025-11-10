# Interfejsy w praktyce: `IShape`, `Circle`, `Rectangle`

Program w C# demonstrujący wykorzystanie interfejsów do ujednolicenia API dla różnych kształtów geometrycznych. Interfejs `IShape` definiuje kontrakt, który implementują klasy `Circle` oraz `Rectangle`. Przykład pokazuje polimorfizm poprzez kolekcję `List<IShape>` oraz prostą walidację danych wejściowych.

## Funkcjonalność

### Interfejs `IShape`

- **Właściwości:**
  - `string Name` — nazwa kształtu.
  - `double Area` — pole powierzchni.
  - `double Perimeter` — obwód.

### Klasa `Circle` (implementacja `IShape`)

- **Właściwości publiczne:**
  - `double Radius` — z walidacją wartości dodatniej.
  - Implementacje z interfejsu:  
    `Name => "Koło"`, `Area => Math.PI * r^2`, `Perimeter => 2 * Math.PI * r`.
- **Walidacja:**
  - Ustawienie `Radius <= 0` rzuca `ArgumentException("Promień (Radius) musi być liczbą dodatnią.")`.

### Klasa `Rectangle` (implementacja `IShape`)

- **Właściwości publiczne:**
  - `double Width`, `double Height` — obie z walidacją wartości dodatniej.
  - Implementacje z interfejsu:  
    `Name => "Prostokąt"`, `Area => Width * Height`, `Perimeter => 2 * (Width + Height)`.
- **Walidacja:**
  - `Width <= 0` lub `Height <= 0` rzuca `ArgumentException` z odpowiednim komunikatem.

### Polimorfizm i obsługa błędów

- Kształty są przechowywane w kolekcji `List<IShape>`, co umożliwia jednolite wywołania `Name`, `Area`, `Perimeter` niezależnie od typu.
- Tworzenie obiektów jest otoczone blokiem `try/catch`; błędne dane skutkują komunikatem o błędzie, a program działa dalej dla poprawnych elementów.

## Ocena zadania

Zadanie oceniam na średnio trudne
