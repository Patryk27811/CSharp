# Moq: Mockowanie repozytorium w testach

Program konsolowy w C# (.NET) demonstrujący użycie biblioteki Moq do mockowania zależności w testach jednostkowych.

---

## Funkcjonalność

- Interfejs `IProduktRepository` z metodami `PobierzNazwy` i `Liczba`.
- Klasa `ProduktService` zależna od interfejsu (wstrzykiwanie zależności).
- Testy używają `Mock<IProduktRepository>` do tworzenia atrap.
- Weryfikacja wywołań metodą `mockRepo.Verify(...)`.
- Prawdziwa implementacja `PrawdziwyProduktRepository` do użytku produkcyjnego.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
