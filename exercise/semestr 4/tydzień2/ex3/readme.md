# CSV: Wczytywanie i wypisywanie wierszy

Program konsolowy w C# (.NET) do wczytywania plików CSV i wyświetlania ich zawartości w sformatowany sposób.

---

## Funkcjonalność

- Klasa `CsvCzytnik` z metodą `WczytajCsv` czyta plik CSV linia po linii.
- Parsuje każdą linię na tablicę kolumn według podanego separatora (domyślnie `,`).
- Pomija puste linie.
- Rzuca `FileNotFoundException` gdy plik nie istnieje.
- Metoda `WypiszCsv` wyświetla wiersze w konsoli z separatorem ` | `.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
