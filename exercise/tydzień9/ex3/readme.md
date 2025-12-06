# Operator + dla Wektor2D

Program w C# demonstrujący mechanizm **przeciążania operatorów** na przykładzie matematycznego wektora dwuwymiarowego.

---

## Funkcjonalność

Program definiuje klasę `Wektor2D` reprezentującą punkt lub wektor w przestrzeni 2D (współrzędne X i Y).

- **Przeciążenie operatora `+`:** Umożliwia dodawanie dwóch obiektów klasy `Wektor2D` za pomocą naturalnej składni `w1 + w2`.
- **Logika:** Wynikiem dodawania jest nowy wektor, którego współrzędna X to suma X-ów składników, a Y to suma Y-ów.
- **Niezmienność (Immutability):** Obiekty `Wektor2D` są niezmienne – dodawanie nie modyfikuje istniejących obiektów, lecz zwraca zupełnie nową instancję.
- **Metoda `ToString`:** Nadpisana w celu czytelnego wyświetlania wektora w formacie `[x, y]`.

---

## Uruchomienie

1. Otwórz terminal w katalogu projektu.
2. Uruchom komendę:
   dotnet run --project src/src.csproj

---

## Ocena zadania

Według mnie zadanie było średnio trudne.
