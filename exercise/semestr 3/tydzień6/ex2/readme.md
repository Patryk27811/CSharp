# Konto Bankowe

Prosty program konsolowy w C# symulujący działanie konta bankowego z walidacją operacji finansowych.

---

## Funkcjonalność

Program umożliwia interakcję z obiektem klasy `KontoBankowe`.

- **Wpłata (`Wplac`):** Dodaje środki do salda. Rzuca wyjątek `ArgumentException`, jeśli kwota jest ujemna lub zerowa.
- **Wypłata (`Wyplac`):** Odejmuje środki z salda. Rzuca wyjątek `InvalidOperationException`, jeśli na koncie nie ma wystarczających środków, lub `ArgumentException` przy błędnej kwocie.
- **Saldo:** Jest właściwością tylko do odczytu (`private set`), co gwarantuje bezpieczeństwo danych (nie można go zmienić bezpośrednio, tylko przez metody).
- **Typ `decimal`:** Używany do operacji pieniężnych dla zachowania precyzji.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnio-trudne.
