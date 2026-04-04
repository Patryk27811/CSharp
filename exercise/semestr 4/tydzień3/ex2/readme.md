# JSON: Wczytywanie i wypisywanie pól obiektu

Program konsolowy w C# (.NET), który deserializuje obiekt z formatu JSON i wyświetla jego pola.

---

## Funkcjonalność

- Definiuje rekord `KonfigAplikacji` z polami `Nazwa`, `Wersja`, `DebugMode`.
- Klasa `JsonCzytnik` z generyczną metodą `WczytajJson<T>` deserializuje JSON.
- Używa `System.Text.Json` z opcją `PropertyNameCaseInsensitive`.
- Rzuca `ArgumentException` dla pustego JSON.
- Wyświetla wartości pól w konsoli.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnie.
