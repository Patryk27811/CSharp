# Program Walidacja Wypłaty

Program w C# demonstrujący mechanizm zabezpieczenia przed debetem na koncie bankowym.

---

## Funkcjonalność

Program tworzy konto z początkowym saldem 100 PLN, a następnie prosi użytkownika o podanie kwoty do wypłaty.

- Kluczową funkcją jest metoda `Wyplac`.
- Sprawdza ona, czy żądana kwota nie przekracza dostępnego salda (`kwota > Saldo`).
- Jeśli środków jest za mało, program **zabrania operacji**, rzucając wyjątek `InvalidOperationException` z komunikatem "Brak wystarczających środków na koncie".
- Główny program przechwytuje ten wyjątek i wyświetla komunikat o odmowie wypłaty, zamiast kończyć działanie błędem.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
