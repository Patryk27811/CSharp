# Test: Weryfikacja poprawności serializacji JSON

Program konsolowy w C# (.NET) z testami sprawdzającymi poprawność round-trip serializacji obiektu ToDo do/z JSON.

---

## Funkcjonalność

- Rekord `TodoItemFull` z opcjonalnym polem `Opis` (nullable).
- Klasa `JsonValidator` z metodami `Serializuj`, `Deserializuj` i `CzySerializacjaPoprawna`.
- `CzySerializacjaPoprawna` wykonuje pełny round-trip: serializacja → deserializacja → porównanie.
- Testy sprawdzają zachowanie pól, null-safety i obsługę błędów.
- Używa `System.Text.Json` z ustawieniem `PropertyNameCaseInsensitive`.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
