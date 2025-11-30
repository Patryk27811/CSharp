# Gra Zgadnij Liczbę

Prosta gra konsolowa w C#, w której użytkownik musi odgadnąć wylosowaną przez komputer liczbę całkowitą.

---

## Funkcjonalność

Program losuje liczbę z zakresu od 1 do 100.

- Użytkownik w pętli podaje swoje propozycje liczb.
- Program porównuje strzał użytkownika z wylosowaną liczbą używając logiki wydzielonej do klasy `LogikaGry`.
- Wyświetla podpowiedzi: "Za mało", "Za dużo" lub "Trafiony".
- Zlicza liczbę prób potrzebnych do odgadnięcia.
- Waliduje wejście, upewniając się, że wprowadzono liczbę (`int.TryParse`).

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
