public class ProduktWalidacjaTests
{
    [Fact]
    public void Konstruktor_TworzeProduktZPoprawnymDanymi()
    {
        var p = new Produkt("Laptop", 1000m);
        Assert.Equal("Laptop", p.Nazwa);
        Assert.Equal(1000m, p.Cena);
    }

    [Fact]
    public void Cena_MozeByc_Zero()
    {
        var p = new Produkt("Darmowy", 0m);
        Assert.Equal(0m, p.Cena);
    }

    [Fact]
    public void Cena_RzucaWyjatek_GdyUjemna()
    {
        var ex = Assert.Throws<BladWalidacjiException>(() => new Produkt("Test", -1m));
        Assert.Equal("Cena", ex.NazwaPola);
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    public void Nazwa_RzucaWyjatek_GdyPusta(string nazwa)
    {
        var ex = Assert.Throws<BladWalidacjiException>(() => new Produkt(nazwa, 10m));
        Assert.Equal("Nazwa", ex.NazwaPola);
    }

    [Fact]
    public void BladWalidacjiException_ZawieraNazwePola()
    {
        var ex = new BladWalidacjiException("TestPole", "Błąd testowy");
        Assert.Equal("TestPole", ex.NazwaPola);
    }
}
