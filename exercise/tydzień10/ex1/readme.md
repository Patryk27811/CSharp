# Konwerter Temperatur (°C ↔ °F)

Prosty program konsolowy w C# umożliwiający przeliczanie temperatury między skalą Celsjusza a Fahrenheita.

---

## Funkcjonalność

Program wyświetla menu wyboru kierunku konwersji, a następnie prosi o podanie wartości liczbowej.

- **Logika:**
  - Celsjusz na Fahrenheit: `(C * 9/5) + 32`
  - Fahrenheit na Celsjusz: `(F - 32) * 5/9`
- **Precyzja:** Program używa typu `double` dla zachowania dokładności, a wynik wyświetlany jest z zaokrągleniem do dwóch miejsc po przecinku (`F2`).
- **Implementacja:** Zwraca uwagę na dzielenie zmiennoprzecinkowe (użycie `5.0 / 9.0` zamiast całkowitego `5 / 9`, które dałoby zero).
- **Obsługa błędów:** Wyłapuje błąd formatu, jeśli użytkownik wpisze tekst zamiast liczby.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było łatwe.
