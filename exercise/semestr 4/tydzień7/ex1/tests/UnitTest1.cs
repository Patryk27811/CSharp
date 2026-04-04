public class SumatorPlikuTests
{
    private string UtworzPlikZLiczabami(string[] linie)
    {
        string plik = Path.GetTempFileName();
        File.WriteAllLines(plik, linie);
        return plik;
    }

    [Fact]
    public void SumujLiczbyZPliku_ZwracaPoprawnaSume()
    {
        string plik = UtworzPlikZLiczabami(new[] { "10", "20", "30" });
        try
        {
            Assert.Equal(60, SumatorPliku.SumujLiczbyZPliku(plik));
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void SumujLiczbyZPliku_PomijaNieLiczby()
    {
        string plik = UtworzPlikZLiczabami(new[] { "5", "abc", "10", "" });
        try
        {
            Assert.Equal(15, SumatorPliku.SumujLiczbyZPliku(plik));
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void SumujLiczbyZPliku_PustyPlik_ZwracaZero()
    {
        string plik = UtworzPlikZLiczabami(Array.Empty<string>());
        try
        {
            Assert.Equal(0, SumatorPliku.SumujLiczbyZPliku(plik));
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void SumujLiczbyZPliku_RzucaWyjatek_GdyPlikNieIstnieje()
    {
        Assert.Throws<FileNotFoundException>(() =>
            SumatorPliku.SumujLiczbyZPliku("nieistniejacy.txt"));
    }
}
