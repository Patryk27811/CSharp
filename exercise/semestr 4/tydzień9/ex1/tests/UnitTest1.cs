public class FileLoggerTests
{
    [Fact]
    public void Zapisz_DodajeWpisDoPliku()
    {
        string plik = Path.GetTempFileName();
        try
        {
            using var logger = new FileLogger(plik);
            logger.Zapisz("test");
            var linie = File.ReadAllLines(plik);
            Assert.NotEmpty(linie);
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void Zapisz_WpisZawieraPoziomLogu()
    {
        string plik = Path.GetTempFileName();
        try
        {
            using var logger = new FileLogger(plik);
            logger.Zapisz("błąd", PoziomLogu.Blad);
            var zawartosc = File.ReadAllText(plik);
            Assert.Contains("Blad", zawartosc);
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void Zapisz_WpisZawieraKomunikat()
    {
        string plik = Path.GetTempFileName();
        try
        {
            using var logger = new FileLogger(plik);
            logger.Zapisz("unikalny komunikat");
            var zawartosc = File.ReadAllText(plik);
            Assert.Contains("unikalny komunikat", zawartosc);
        }
        finally { File.Delete(plik); }
    }

    [Fact]
    public void Konstruktor_RzucaWyjatek_DlaPustejSciezki()
    {
        Assert.Throws<ArgumentException>(() => new FileLogger(""));
    }
}
