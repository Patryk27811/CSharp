# LINQ: Filtrowanie listy ToDo po statusie i kategorii

Program konsolowy w C# (.NET) demonstrujący zaawansowane filtrowanie i grupowanie listy zadań przy użyciu LINQ.

---

## Funkcjonalność

- Rekord `TodoItemEx` z dodatkowym polem `Kategoria`.
- Klasa `TodoFilter` z metodami: `FiltrujPoStatusie`, `FiltrujPoKategorii`, `StatsyPoKategoriach`.
- Filtrowanie zwraca nową listę (oryginał niezmieniony).
- `StatsyPoKategoriach` grupuje zadania i zlicza je per kategoria.
- Porównanie kategorii jest case-insensitive.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnie.
