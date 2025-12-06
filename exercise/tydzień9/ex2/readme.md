# Zarządzanie Grupą Studentów (Lista i Średnia)

Program w C# służący do zarządzania listą studentów w grupie oraz obliczania ich średniej ocen.

---

## Funkcjonalność

Program pozwala na utworzenie grupy studenckiej i dodawanie do niej obiektów reprezentujących studentów.

- **Klasa `Student`:** Przechowuje imię i ocenę. Waliduje poprawność oceny (zakres 2.0 - 6.0).
- **Klasa `GrupaStudencka`:**
  - Przechowuje listę studentów (`List<Student>`).
  - Umożliwia dodawanie nowych studentów.
  - Metoda `ObliczSrednia()` wykorzystuje LINQ (`Average`) do wyliczenia średniej arytmetycznej ocen wszystkich studentów w grupie.
  - Zabezpiecza przed dzieleniem przez zero w przypadku pustej listy (zwraca 0.0).

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnio-łatwe.
