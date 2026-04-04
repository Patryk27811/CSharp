using System.Linq;

public class AnalizatorSlowTests
{
    [Fact]
    public void ZliczSlowa_LiczyPoprawnaCzestosc()
    {
        var wynik = AnalizatorSlow.ZliczSlowa("ala ma kota kota");
        Assert.Equal(2, wynik["kota"]);
        Assert.Equal(1, wynik["ala"]);
    }

    [Fact]
    public void ZliczSlowa_IgnorujeWielkoscLiter()
    {
        var wynik = AnalizatorSlow.ZliczSlowa("Ala ala ALA");
        Assert.Equal(3, wynik["ala"]);
    }

    [Fact]
    public void ZliczSlowa_PustyTekst_ZwracaPustySlownik()
    {
        var wynik = AnalizatorSlow.ZliczSlowa("");
        Assert.Empty(wynik);
    }

    [Fact]
    public void ZliczSlowa_LiczyUnikalneSlowa()
    {
        var wynik = AnalizatorSlow.ZliczSlowa("a b c d");
        Assert.Equal(4, wynik.Count);
    }
}
