# Symulator Samochodu (Paliwo i Dystans)

Program konsolowy w C# symulujący podróż samochodem i obliczający zużycie paliwa.

---

## Funkcjonalność

Program tworzy obiekt samochodu z określoną ilością paliwa i średnim spalaniem, a następnie prosi użytkownika o podanie dystansu.

- **Metoda `Jedz(double km)`:**
  - Oblicza zapotrzebowanie na paliwo według wzoru: `(dystans / 100) * spalanie`.
  - Sprawdza, czy w baku jest wystarczająca ilość paliwa.
  - Jeśli tak: odejmuje zużyte paliwo od aktualnego stanu.
  - Jeśli nie: rzuca wyjątek `InvalidOperationException` z informacją o braku paliwa.
- **Walidacja:** Blokuje podawanie ujemnego dystansu oraz tworzenie samochodu z błędnymi danymi (ujemne paliwo, zerowe spalanie).

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
