# Kalkulator RPN (Stos)

Program konsolowy w C# obliczający wartość wyrażeń matematycznych zapisanych w Odwrotnej Notacji Polskiej (RPN), wykorzystujący strukturę danych **Stos**.

---

## Funkcjonalność

Program prosi użytkownika o podanie ciągu znaków reprezentującego wyrażenie RPN (np. `3 4 + 2 *`).

- **Algorytm:**
  - Przechodzi przez wyrażenie od lewej do prawej.
  - Jeśli napotka liczbę, wrzuca ją na stos (`Push`).
  - Jeśli napotka operator (+, -, \*, /), zdejmuje dwie ostatnie liczby ze stosu (`Pop`), wykonuje działanie i wrzuca wynik z powrotem na stos.
  - Wynikiem końcowym jest ostatnia liczba pozostająca na stosie.
- **Obsługa błędów:** Wykrywa nieprawidłowe wyrażenia (np. za mało liczb dla operatora), nieznane operatory oraz dzielenie przez zero.
- **Typ danych:** Obsługuje liczby zmiennoprzecinkowe (`double`).

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnio trudne.
