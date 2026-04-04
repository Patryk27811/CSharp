public class KsiazkaRepositoryTests
{
    private KsiazkaRepository UtworzRepo() => new KsiazkaRepository();

    [Fact]
    public void Dodaj_ZwracaKsiazkeZNadanymId()
    {
        var repo = UtworzRepo();
        var k = repo.Dodaj(new Ksiazka(0, "Test", "Autor"));
        Assert.True(k.Id > 0);
    }

    [Fact]
    public void PobierzWszystkie_ZwracaWszystkieKsiazki()
    {
        var repo = UtworzRepo();
        repo.Dodaj(new Ksiazka(0, "A", "X"));
        repo.Dodaj(new Ksiazka(0, "B", "Y"));
        Assert.Equal(2, repo.PobierzWszystkie().Count());
    }

    [Fact]
    public void Znajdz_ZwracaNulla_GdyNieIstnieje()
    {
        var repo = UtworzRepo();
        Assert.Null(repo.Znajdz(999));
    }

    [Fact]
    public void Usun_ZwracaFalse_GdyNieIstnieje()
    {
        var repo = UtworzRepo();
        Assert.False(repo.Usun(999));
    }

    [Fact]
    public void Dodaj_RzucaWyjatek_DlaNulla()
    {
        var repo = UtworzRepo();
        Assert.Throws<ArgumentNullException>(() => repo.Dodaj(null!));
    }

    [Fact]
    public void ImplementujeInterfejs()
    {
        IRepository<Ksiazka> repo = new KsiazkaRepository();
        Assert.NotNull(repo);
    }
}
