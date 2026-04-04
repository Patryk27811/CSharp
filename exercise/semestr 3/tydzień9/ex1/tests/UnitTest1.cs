using System;
using Xunit;

public class KoloTests
{
    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(2, 12.5663706)]
    [InlineData(10, 314.159265)]
    public void ObliczPole_ZwracaPoprawnyWynik(double promien, double oczekiwanyWynik)
    {
        Kolo kolo = new Kolo(promien);
        
        double wynik = kolo.ObliczPole();

        Assert.Equal(oczekiwanyWynik, wynik, 4);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void Konstruktor_RzucaWyjatek_GdyPromienJestNieprawidlowy(double promien)
    {
        Assert.Throws<ArgumentException>(() => new Kolo(promien));
    }
}