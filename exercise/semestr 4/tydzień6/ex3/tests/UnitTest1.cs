public class KopiowanieTests
{
    private (string zrodlo, string cel) UtworzPliki(string[] zawartosc)
    {
        string zrodlo = Path.GetTempFileName();
        string cel = Path.GetTempFileName();
        File.WriteAllLines(zrodlo, zawartosc);
        return (zrodlo, cel);
    }

    [Fact]
    public void Kopiuj_TworzeIdentycznaZawartosc()
    {
        var (zrodlo, cel) = UtworzPliki(new[] { "a", "b", "c" });
        try
        {
            KopiowaniePliku.Kopiuj(zrodlo, cel);
            var linie = File.ReadAllLines(cel);
            Assert.Equal(new[] { "a", "b", "c" }, linie);
        }
        finally { File.Delete(zrodlo); File.Delete(cel); }
    }

    [Fact]
    public void Kopiuj_RzucaWyjatek_GdyZrodloNieIstnieje()
    {
        Assert.Throws<FileNotFoundException>(() =>
            KopiowaniePliku.Kopiuj("nieistniejacy.txt", "cel.txt"));
    }

    [Fact]
    public void Kopiuj_RzucaWyjatek_GdyCelPusty()
    {
        string zrodlo = Path.GetTempFileName();
        try
        {
            Assert.Throws<ArgumentException>(() => KopiowaniePliku.Kopiuj(zrodlo, ""));
        }
        finally { File.Delete(zrodlo); }
    }

    [Fact]
    public void Kopiuj_PustyPlik_TworzeNiepustyPlik()
    {
        var (zrodlo, cel) = UtworzPliki(Array.Empty<string>());
        try
        {
            KopiowaniePliku.Kopiuj(zrodlo, cel);
            Assert.True(File.Exists(cel));
        }
        finally { File.Delete(zrodlo); File.Delete(cel); }
    }
}
