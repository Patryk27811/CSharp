using System.Linq;

public class SortowanieMalejacoTests
{
    [Fact]
    public void SortujMalejaco_ZwracaPoprawnaPozycje()
    {
        var lista = new List<string> { "a", "c", "b" };
        var wynik = Program.SortujMalejaco(lista);
        Assert.Equal(new[] { "c", "b", "a" }, wynik);
    }

    [Fact]
    public void SortujMalejaco_PustaLista_ZwracaPusta()
    {
        var wynik = Program.SortujMalejaco(new List<string>());
        Assert.Empty(wynik);
    }

    [Fact]
    public void SortujMalejaco_JedenElement_ZwracaJedenElement()
    {
        var wynik = Program.SortujMalejaco(new List<string> { "jeden" });
        Assert.Single(wynik);
    }

    [Fact]
    public void SortujMalejaco_RzucaWyjatek_DlaNulla()
    {
        Assert.Throws<ArgumentNullException>(() => Program.SortujMalejaco(null!));
    }
}
