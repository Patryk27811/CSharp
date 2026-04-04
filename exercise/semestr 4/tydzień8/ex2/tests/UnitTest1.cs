public class OrderServiceTests
{
    private Zamowienie UtworzZamowienie(params (string, decimal, int)[] pozycje) =>
        new Zamowienie(1, pozycje.Select(p => new PozycjaZamowienia(p.Item1, p.Item2, p.Item3)).ToList());

    [Fact]
    public void ObliczWartosc_PoprawnaWartosc()
    {
        var z = UtworzZamowienie(("A", 100m, 2), ("B", 50m, 3));
        Assert.Equal(350m, OrderService.ObliczWartosc(z));
    }

    [Fact]
    public void ObliczWartosc_PusteZamowienie_ZwracaZero()
    {
        var z = new Zamowienie(1, new List<PozycjaZamowienia>());
        Assert.Equal(0m, OrderService.ObliczWartosc(z));
    }

    [Fact]
    public void ObliczZRabatem_ZwracaPoprawnaWartosc()
    {
        var z = UtworzZamowienie(("A", 100m, 1));
        Assert.Equal(90m, OrderService.ObliczZRabatem(z, 10));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(101)]
    public void ObliczZRabatem_RzucaWyjatek_GdyNiepoprawnyRabat(decimal rabat)
    {
        var z = UtworzZamowienie(("A", 10m, 1));
        Assert.Throws<ArgumentException>(() => OrderService.ObliczZRabatem(z, rabat));
    }

    [Fact]
    public void ObliczWartosc_RzucaWyjatek_DlaNullZamowienia()
    {
        Assert.Throws<ArgumentNullException>(() => OrderService.ObliczWartosc(null!));
    }
}
