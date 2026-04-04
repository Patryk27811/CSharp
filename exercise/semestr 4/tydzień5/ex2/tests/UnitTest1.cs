public class ProductRepositoryTests
{
    [Fact]
    public void Dodaj_ZwiekszaLiczbe()
    {
        var repo = new ProductRepository();
        repo.Dodaj("Test", 10.0m);
        Assert.Equal(1, repo.Liczba);
    }

    [Fact]
    public void Dodaj_ZwracaProductZId()
    {
        var repo = new ProductRepository();
        var p = repo.Dodaj("Laptop", 1000m);
        Assert.True(p.Id > 0);
        Assert.Equal("Laptop", p.Nazwa);
    }

    [Fact]
    public void Znajdz_ZwracaProdukt_GdyIstnieje()
    {
        var repo = new ProductRepository();
        var dodany = repo.Dodaj("Test", 5m);
        var znaleziony = repo.Znajdz(dodany.Id);
        Assert.NotNull(znaleziony);
    }

    [Fact]
    public void Usun_ZwracaTrue_GdyUsunietoPomyslnie()
    {
        var repo = new ProductRepository();
        var p = repo.Dodaj("Test", 1m);
        Assert.True(repo.Usun(p.Id));
        Assert.Equal(0, repo.Liczba);
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    public void Dodaj_RzucaWyjatek_GdyNazwaPusta(string nazwa)
    {
        var repo = new ProductRepository();
        Assert.Throws<ArgumentException>(() => repo.Dodaj(nazwa, 10m));
    }

    [Fact]
    public void Dodaj_RzucaWyjatek_GdyCenaUjemna()
    {
        var repo = new ProductRepository();
        Assert.Throws<ArgumentException>(() => repo.Dodaj("Test", -1m));
    }
}
