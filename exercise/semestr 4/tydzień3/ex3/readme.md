# JSON: Serializacja obiektu User do pliku

Program konsolowy w C# (.NET) do serializowania i deserializowania obiektu użytkownika do/z pliku JSON.

---

## Funkcjonalność

- Definiuje rekord `User` z polami `Login`, `Email`, `Wiek`.
- Klasa `UserRepository` z metodami `ZapiszDoPliku` i `WczytajZPliku`.
- Serializuje obiekt do sformatowanego JSON (`WriteIndented = true`).
- Odczytuje JSON z pliku i deserializuje z powrotem do obiektu.
- Obsługuje błędy: null, brak pliku.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
