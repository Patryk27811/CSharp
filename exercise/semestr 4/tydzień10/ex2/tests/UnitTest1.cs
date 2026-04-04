using System.Linq;

public class TodoFilterTests
{
    private List<TodoItemEx> DomyslnaLista() => new()
    {
        new(1, "A", true, "Praca"),
        new(2, "B", false, "Dom"),
        new(3, "C", true, "Praca"),
        new(4, "D", false, "Dom")
    };

    [Fact]
    public void FiltrujPoStatusie_Ukonczone_ZwracaTylkoUkonczone()
    {
        var wynik = TodoFilter.FiltrujPoStatusie(DomyslnaLista(), true);
        Assert.Equal(2, wynik.Count);
        Assert.All(wynik, t => Assert.True(t.Ukonczone));
    }

    [Fact]
    public void FiltrujPoStatusie_Nieukonczone_ZwracaTylkoNieukonczone()
    {
        var wynik = TodoFilter.FiltrujPoStatusie(DomyslnaLista(), false);
        Assert.Equal(2, wynik.Count);
        Assert.All(wynik, t => Assert.False(t.Ukonczone));
    }

    [Fact]
    public void FiltrujPoKategorii_ZwracaPoprawnePozycje()
    {
        var wynik = TodoFilter.FiltrujPoKategorii(DomyslnaLista(), "Praca");
        Assert.Equal(2, wynik.Count);
    }

    [Fact]
    public void StatsyPoKategoriach_ZwracaPoprawneLiczby()
    {
        var stats = TodoFilter.StatsyPoKategoriach(DomyslnaLista());
        Assert.Equal(2, stats["Praca"]);
        Assert.Equal(2, stats["Dom"]);
    }

    [Fact]
    public void FiltrujPoStatusie_RzucaWyjatek_DlaNulla()
    {
        Assert.Throws<ArgumentNullException>(() => TodoFilter.FiltrujPoStatusie(null!, true));
    }
}
