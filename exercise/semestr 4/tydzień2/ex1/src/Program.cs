using System.Linq;

public record Pracownik(int Id, string Imie, int DzialId);
public record Dzial(int Id, string Nazwa);

public static class Program
{
    public static IEnumerable<string> JoinPracownicyDzialy(
        List<Pracownik> pracownicy,
        List<Dzial> dzialy)
    {
        return pracownicy
            .Join(dzialy,
                  p => p.DzialId,
                  d => d.Id,
                  (p, d) => $"{p.Imie} - {d.Nazwa}");
    }

    static void Main()
    {
        var pracownicy = new List<Pracownik>
        {
            new(1, "Anna", 10),
            new(2, "Bartek", 20),
            new(3, "Celina", 10)
        };
        var dzialy = new List<Dzial>
        {
            new(10, "IT"),
            new(20, "HR")
        };

        foreach (var wynik in JoinPracownicyDzialy(pracownicy, dzialy))
            Console.WriteLine(wynik);
    }
}
