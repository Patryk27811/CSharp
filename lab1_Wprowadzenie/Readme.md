# 🧮 Lab01 – Wprowadzenie do .NET i prosty kalkulator CLI

Ten projekt to wprowadzenie do środowiska **.NET 8/9**.  
Zawiera prostą aplikację konsolową typu **CLI (Command-Line Interface)** napisaną w C#, która realizuje podstawowe działania matematyczne oraz prezentuje obsługę błędnych danych wejściowych bez crasha.

---

## 🎯 Cele laboratorium

- Instalacja i konfiguracja środowiska **.NET SDK**
- Tworzenie i uruchamianie aplikacji konsolowej (`dotnet new console`)
- Zrozumienie struktury projektu (`.sln`, `.csproj`, `Program.cs`)
- Dodanie zewnętrznego pakietu NuGet (`System.CommandLine`)
- Implementacja prostego kalkulatora CLI (`add`, `sub`)
- Testowanie i obsługa błędów bez przerywania działania programu

---

## Uruchamianie programu

dotnet run --project src/src.csproj -- calc add 5 3

# Wynik: 8

dotnet run --project src/src.csproj -- calc sub 10 4

# Wynik: 6
