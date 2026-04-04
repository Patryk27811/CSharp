# HTTP JSON: Deserializacja listy obiektów

Program konsolowy w C# (.NET) demonstrujący deserializację listy obiektów z formatu JSON (symulacja odpowiedzi HTTP API).

---

## Funkcjonalność

- Definiuje rekord `PostApi` odpowiadający strukturze odpowiedzi REST API.
- Klasa `JsonDeserializator` z generyczną metodą `DeserializujListe<T>`.
- Używa `System.Text.Json` z opcją `PropertyNameCaseInsensitive`.
- Obsługuje pustą tablicę JSON i rzuca wyjątek dla pustego stringa.
- Wyświetla listę deserializowanych obiektów.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnie.
