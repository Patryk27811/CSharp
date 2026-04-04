using System.Linq;

public class JoinTests
{
    private static List<Pracownik> DomyslniPracownicy() => new()
    {
        new(1, "Anna", 10),
        new(2, "Bartek", 20),
        new(3, "Celina", 10)
    };

    private static List<Dzial> DomyslneDzialy() => new()
    {
        new(10, "IT"),
        new(20, "HR")
    };

    [Fact]
    public void Join_ZwracaPoprawneLiczbeWynikow()
    {
        var wyniki = Program.JoinPracownicyDzialy(DomyslniPracownicy(), DomyslneDzialy()).ToList();
        Assert.Equal(3, wyniki.Count);
    }

    [Fact]
    public void Join_ZwracaPoprawnePary()
    {
        var wyniki = Program.JoinPracownicyDzialy(DomyslniPracownicy(), DomyslneDzialy()).ToList();
        Assert.Contains("Anna - IT", wyniki);
        Assert.Contains("Bartek - HR", wyniki);
    }

    [Fact]
    public void Join_BezPasujacychDzialow_ZwracaPusta()
    {
        var pracownicy = new List<Pracownik> { new(1, "Anna", 99) };
        var dzialy = new List<Dzial> { new(10, "IT") };
        var wyniki = Program.JoinPracownicyDzialy(pracownicy, dzialy).ToList();
        Assert.Empty(wyniki);
    }
}
