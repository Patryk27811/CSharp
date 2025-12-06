# Program Pole Koła (Circle.Area)

Prosty program konsolowy w C# obliczający pole powierzchni koła na podstawie podanego promienia.

---

## Funkcjonalność

Program prosi użytkownika o podanie promienia koła.

- **Klasa `Kolo`:** Przechowuje promień i udostępnia metodę `ObliczPole()`.
- **Obliczenia:** Wykorzystuje stałą matematyczną `Math.PI` oraz funkcję potęgowania `Math.Pow` do wyliczenia pola ze wzoru πr².
- **Walidacja:** Konstruktor klasy uniemożliwia utworzenie koła o promieniu ujemnym lub równym zeru, rzucając wyjątek `ArgumentException`.
- **Precyzja:** Wynik wyświetlany jest z dokładnością do 4 miejsc po przecinku.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było bardzo łatwe.
