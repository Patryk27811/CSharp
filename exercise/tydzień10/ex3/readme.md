# Mini-Projekt: Kalkulator CLI

Kompletny program konsolowy w C# realizujący funkcje prostego kalkulatora matematycznego z interaktywnym menu.

---

## Funkcjonalność

Program działa w pętli, umożliwiając wykonywanie wielu obliczeń bez konieczności ponownego uruchamiania.

- **Menu główne:** Użytkownik wybiera operację z listy (1-5) lub wyjście (0).
- **Obsługiwane operacje:**
  - Dodawanie (+)
  - Odejmowanie (-)
  - Mnożenie (\*)
  - Dzielenie (/) – z zabezpieczeniem przed dzieleniem przez zero (`DivideByZeroException`).
  - Potęgowanie (^) – wykorzystuje `Math.Pow`.
- **Obsługa błędów:**
  - Odporność na wprowadzanie tekstu zamiast liczb (pętla walidująca w metodzie `PobierzLiczbe`).
  - Przechwytywanie wyjątków matematycznych.
- **Separacja logiki:** Obliczenia są wydzielone do statycznej klasy `Kalkulator`, co ułatwia testowanie jednostkowe, oddzielając logikę od interfejsu użytkownika (UI).

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnio trudne.
