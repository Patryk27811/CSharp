# Program Dni Tygodnia (Enum)

Prosty program konsolowy w C# demonstrujący działanie typu wyliczeniowego (`enum`) oraz konwersję liczb na wartości symboliczne.

---

## Funkcjonalność

Program prosi użytkownika o podanie numeru dnia (1-7).

- **Enum `DzienTygodnia`:** Definiuje dni tygodnia, przypisując im wartości liczbowe od 1 (Poniedziałek) do 7 (Niedziela).
- **Walidacja:** Używa metody `Enum.IsDefined`, aby sprawdzić, czy wprowadzona liczba mieści się w zdefiniowanym zakresie enuma.
- **Rzutowanie:** Konwertuje liczbę całkowitą (`int`) na typ wyliczeniowy (`(DzienTygodnia)numer`).
- **Logika:** Metoda `CzyWeekend` sprawdza, czy wylosowany/wybrany dzień to Sobota lub Niedziela.
- **Formatowanie:** Wyświetla nazwę dnia (z enuma) oraz informację, czy jest to dzień roboczy, czy weekend.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnio-łatwe.
