# XML: Wyciąganie wartości elementów <title>

Program konsolowy w C# (.NET) do parsowania dokumentów XML i wyciągania wartości wszystkich elementów `<title>`.

---

## Funkcjonalność

- Klasa `XmlParser` z metodą `WyciagnijTytuly` używającą LINQ to XML.
- Parsuje XML za pomocą `XDocument.Parse`.
- Używa `Descendants("title")` do znalezienia wszystkich elementów `<title>` na dowolnej głębokości.
- Rzuca `ArgumentException` dla pustego lub null XML.
- Zwraca listę stringów z wartościami tytułów.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnie.
