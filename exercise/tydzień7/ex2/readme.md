# Licznik Statystyk Pliku

Program w C# służący do analizy plików tekstowych pod kątem ich zawartości.

---

## Funkcjonalność

Program prosi użytkownika o podanie ścieżki do pliku na dysku.

- **Wczytywanie:** Sprawdza, czy plik istnieje (`File.Exists`), a następnie wczytuje jego całą zawartość (`File.ReadAllText`).
- **Liczba Znaków:** Oblicza długość całego tekstu.
- **Liczba Słów:** Dzieli tekst po białych znakach (spacja, nowa linia, tabulator), ignorując puste wpisy, co pozwala poprawnie zliczyć rzeczywiste słowa.
- **Liczba Linii:** Zlicza wystąpienia znaków nowej linii.
- **Architektura:** Logika obliczeń jest wydzielona do statycznej klasy `AnalizatorTekstu`, co umożliwia łatwe testowanie bez konieczności operowania na prawdziwych plikach w testach.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było  średnio średnio-łatwe.
