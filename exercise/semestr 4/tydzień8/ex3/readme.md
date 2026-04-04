# Walidacja: Cena produktu nie może być ujemna

Program konsolowy w C# (.NET) demonstrujący walidację danych za pomocą niestandardowego wyjątku i właściwości z logiką walidacji.

---

## Funkcjonalność

- Niestandardowy wyjątek `BladWalidacjiException` z właściwością `NazwaPola`.
- Klasa `Produkt` z walidującymi setterami dla `Nazwa` i `Cena`.
- Setter `Cena` rzuca wyjątek gdy wartość jest ujemna (zero jest dozwolone).
- Setter `Nazwa` rzuca wyjątek dla pustego lub białoznakowego stringa.
- Wyjątek zawiera nazwę pola, które spowodowało błąd.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
