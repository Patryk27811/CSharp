public class CsvCzytnikTests
{
    private string UtworzTymczasowyCsv(string[] linie)
    {
        string sciezka = Path.GetTempFileName();
        File.WriteAllLines(sciezka, linie);
        return sciezka;
    }

    [Fact]
    public void WczytajCsv_ZwracaPoprawneLiczbeWierszy()
    {
        string plik = UtworzTymczasowyCsv(new[] { "a,b,c", "d,e,f", "g,h,i" });
        try
        {
            var wynik = CsvCzytnik.WczytajCsv(plik);
            Assert.Equal(3, wynik.Count);
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void WczytajCsv_ParseujeKolumny()
    {
        string plik = UtworzTymczasowyCsv(new[] { "Anna,Kowalska,25" });
        try
        {
            var wynik = CsvCzytnik.WczytajCsv(plik);
            Assert.Equal("Anna", wynik[0].Kolumny[0]);
            Assert.Equal("25", wynik[0].Kolumny[2]);
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void WczytajCsv_PomijaPusteLinie()
    {
        string plik = UtworzTymczasowyCsv(new[] { "a,b", "", "c,d" });
        try
        {
            var wynik = CsvCzytnik.WczytajCsv(plik);
            Assert.Equal(2, wynik.Count);
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void WczytajCsv_RzucaWyjatek_GdyPlikNieIstnieje()
    {
        Assert.Throws<FileNotFoundException>(() => CsvCzytnik.WczytajCsv("nieistniejacy.csv"));
    }
}
