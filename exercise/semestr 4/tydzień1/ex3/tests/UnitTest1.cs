using System.Linq;

public class GrupujPoWiekuTests
{
    [Fact]
    public void GrupujPoWieku_TworzePoprawneLiczbyGrup()
    {
        var osoby = new List<Osoba>
        {
            new("Anna", 25),
            new("Bartek", 30),
            new("Celina", 25)
        };
        var grupy = Program.GrupujPoWieku(osoby);
        Assert.Equal(2, grupy.Count);
    }

    [Fact]
    public void GrupujPoWieku_GrupaZawieraPoprawneOsoby()
    {
        var osoby = new List<Osoba>
        {
            new("Anna", 25),
            new("Bartek", 25),
            new("Celina", 30)
        };
        var grupy = Program.GrupujPoWieku(osoby);
        Assert.Equal(2, grupy[25].Count);
    }

    [Fact]
    public void GrupujPoWieku_PustaLista_ZwracaPustySlownik()
    {
        var grupy = Program.GrupujPoWieku(new List<Osoba>());
        Assert.Empty(grupy);
    }

    [Fact]
    public void GrupujPoWieku_RzucaWyjatek_DlaNulla()
    {
        Assert.Throws<ArgumentNullException>(() => Program.GrupujPoWieku(null!));
    }
}
