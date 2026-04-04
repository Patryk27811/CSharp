# Repozytorium in-memory dla Product

Program konsolowy w C# (.NET) implementujący wzorzec repozytorium do zarządzania produktami w pamięci.

---

## Funkcjonalność

- Definiuje rekord `Product` z polami `Id`, `Nazwa`, `Cena`.
- Klasa `ProductRepository` przechowuje produkty w liście `List<Product>`.
- Metody: `Dodaj`, `Znajdz`, `PobierzWszystkie`, `Usun`.
- Automatycznie nadaje unikalne ID każdemu produktowi.
- Waliduje dane wejściowe – rzuca wyjątki dla pustej nazwy i ujemnej ceny.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnie.
