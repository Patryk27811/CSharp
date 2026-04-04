## Klasy Person i Student (Dziedziczenie)

Program w C# demonstrujący zasady programowania obiektowego, takie jak dziedziczenie i polimorfizm, na przykładzie klas Person (bazowa) i Student (pochodna).

## Funkcjonalność

    Klasa Person (bazowa):

        Definiuje wspólne właściwości: FirstName, LastName, DateOfBirth.

        Posiada obliczaną właściwość Age (Wiek).

        Zawiera metodę wirtualną GetDescription() zwracającą podstawowy opis.

    Klasa Student (pochodna):

        Dziedziczy wszystkie publiczne cechy z klasy Person.

        Dodaje własne właściwości: StudentId oraz Major (Kierunek).

        Przesłania (override) metodę GetDescription(), aby dostarczyć opis specyficzny dla studenta.

    Walidacja:

        Konstruktory obu klas sprawdzają poprawność danych (np. czy imiona nie są puste, czy data urodzenia nie jest w przyszłości).

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe
