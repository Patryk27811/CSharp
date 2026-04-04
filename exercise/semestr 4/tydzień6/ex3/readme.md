# IO: Kopiowanie pliku za pomocą StreamReader/StreamWriter

Program konsolowy w C# (.NET) do kopiowania zawartości pliku tekstowego przy użyciu niskopoziomowego API strumieni.

---

## Funkcjonalność

- Klasa `KopiowaniePliku` z metodą `Kopiuj` kopiującą plik linia po linii.
- Używa `StreamReader` do odczytu i `StreamWriter` do zapisu.
- Poprawnie zwalnia zasoby za pomocą `using`.
- Rzuca `FileNotFoundException` gdy plik źródłowy nie istnieje.
- Wyświetla liczbę skopiowanych linii.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
