using Xunit;

public class GraTests
{
    [Fact]
    public void Sprawdz_ZwracaZaMalo_GdyStrzalJestMniejszy()
    {
        var wynik = LogikaGry.Sprawdz(10, 50);
        Assert.Equal(WynikStrzalu.ZaMalo, wynik);
    }

    [Fact]
    public void Sprawdz_ZwracaZaDuzo_GdyStrzalJestWiekszy()
    {
        var wynik = LogikaGry.Sprawdz(80, 50);
        Assert.Equal(WynikStrzalu.ZaDuzo, wynik);
    }

    [Fact]
    public void Sprawdz_ZwracaTrafiony_GdyStrzalJestRowny()
    {
        var wynik = LogikaGry.Sprawdz(50, 50);
        Assert.Equal(WynikStrzalu.Trafiony, wynik);
    }
}