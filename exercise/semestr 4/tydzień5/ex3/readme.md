# Interfejs IRepository\<T\> – generyczne repozytorium

Program konsolowy w C# (.NET) demonstrujący wzorzec repozytorium z użyciem interfejsu generycznego.

---

## Funkcjonalność

- Definiuje generyczny interfejs `IRepository<T>` z metodami CRUD.
- Implementacja `KsiazkaRepository` dla rekordu `Ksiazka`.
- Constraint `where T : class` zapewnia bezpieczeństwo typów.
- Interfejs jako typ zmiennej (programowanie do interfejsu, nie implementacji).
- Pełna walidacja wejścia i obsługa błędów.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
