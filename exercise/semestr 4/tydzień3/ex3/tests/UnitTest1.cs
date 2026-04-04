using System.Text.Json;

public class UserRepositoryTests
{
    private string TymczasowaSciezka() => Path.GetTempFileName();

    [Fact]
    public void ZapiszDoPliku_TworzeNiepustyPlik()
    {
        string plik = TymczasowaSciezka();
        try
        {
            UserRepository.ZapiszDoPliku(new User("test", "test@x.com", 25), plik);
            Assert.True(File.Exists(plik));
            Assert.True(new FileInfo(plik).Length > 0);
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void WczytajZPliku_ZwracaPoprawnegoPrzykladowego()
    {
        string plik = TymczasowaSciezka();
        var oryginal = new User("anna", "anna@x.com", 22);
        try
        {
            UserRepository.ZapiszDoPliku(oryginal, plik);
            var wczytany = UserRepository.WczytajZPliku(plik);
            Assert.Equal(oryginal.Login, wczytany!.Login);
            Assert.Equal(oryginal.Email, wczytany.Email);
            Assert.Equal(oryginal.Wiek, wczytany.Wiek);
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void WczytajZPliku_RzucaWyjatek_GdyPlikNieIstnieje()
    {
        Assert.Throws<FileNotFoundException>(() => UserRepository.WczytajZPliku("brak.json"));
    }

    [Fact]
    public void ZapiszDoPliku_RzucaWyjatek_DlaNullUser()
    {
        Assert.Throws<ArgumentNullException>(() => UserRepository.ZapiszDoPliku(null!, "plik.json"));
    }
}
