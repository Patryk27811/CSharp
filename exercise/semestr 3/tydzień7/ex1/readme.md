# Dziennik Ocen

Program w C# wykorzystujący kolekcję `Dictionary` do przechowywania ocen z przedmiotów szkolnych.

---

## Funkcjonalność

Program zarządza ocenami w formacie Klucz (Nazwa przedmiotu) -> Wartość (Ocena).

- **Struktura danych:** Używa `Dictionary<string, int>`, co zapewnia szybki dostęp do oceny na podstawie nazwy przedmiotu.
- **Unikalność kluczy:** Słownik gwarantuje, że jeden przedmiot występuje tylko raz. Dodanie oceny do istniejącego przedmiotu powoduje jej nadpisanie (aktualizację).
- **Walidacja:** Metoda `DodajOcene` sprawdza, czy ocena mieści się w szkolnej skali (1-6).
- **Obliczenia:** Metoda `ObliczSrednia` wykorzystuje LINQ do wyliczenia średniej arytmetycznej z wartości słownika.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
