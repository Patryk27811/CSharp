# Zip: Pakowanie wskazanego folderu

Program konsolowy w C# (.NET) do kompresowania zawartości folderu do archiwum ZIP za pomocą wbudowanego API.

---

## Funkcjonalność

- Klasa `ZipHelper` z metodami `SpakujFolder`, `RozmiarZip`, `ListaZawartosci`.
- Używa `System.IO.Compression.ZipFile` do tworzenia archiwum.
- Nadpisuje istniejący plik ZIP jeśli istnieje.
- Metoda `ListaZawartosci` listuje pliki w archiwum bez rozpakowywania.
- Obsługuje błędy: brak folderu, pusta ścieżka ZIP.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było trudne.
