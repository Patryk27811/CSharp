using System;
using Xunit;

public class SamochodTests
{
    [Fact]
    public void Jedz_ZmniejszaPaliwo_O_PrawidlowaWartosc()
    {
        var auto = new Samochod("Test", 50.0, 5.0);
        
        auto.Jedz(100); 

        Assert.Equal(45.0, auto.Paliwo);
    }

    [Fact]
    public void Jedz_RzucaWyjatek_GdyZaMaloPaliwa()
    {
        var auto = new Samochod("Test", 5.0, 10.0);
        
        Assert.Throws<InvalidOperationException>(() => auto.Jedz(100));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-50)]
    public void Jedz_RzucaWyjatek_GdyDystansJestNiepoprawny(double dystans)
    {
        var auto = new Samochod("Test", 50.0, 5.0);
        Assert.Throws<ArgumentException>(() => auto.Jedz(dystans));
    }

    [Fact]
    public void Konstruktor_UstawiaWlasciwosciPoprawnie()
    {
        var auto = new Samochod("Fiat", 30.0, 6.0);
        
        Assert.Equal("Fiat", auto.Model);
        Assert.Equal(30.0, auto.Paliwo);
        Assert.Equal(6.0, auto.SpalanieNa100Km);
    }
}