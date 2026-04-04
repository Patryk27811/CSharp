# Wzorzec Singleton – implementacja Loggera

Program konsolowy w C# (.NET) implementujący wzorzec projektowy Singleton na przykładzie klasy Logger.

---

## Funkcjonalność

- Klasa `Logger` jako Singleton z thread-safe double-check locking.
- Właściwość statyczna `Instancja` zwraca zawsze ten sam obiekt.
- Metoda `Zapisz` dodaje wpis z datą i godziną.
- Metoda `PobierzLogi` zwraca listę tylko do odczytu.
- Wewnętrzna metoda `Reset` do użytku w testach.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
