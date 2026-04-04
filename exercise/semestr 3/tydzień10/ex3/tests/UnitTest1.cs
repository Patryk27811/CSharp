using System;
using Xunit;

public class KalkulatorTests
{
    [Fact]
    public void Dodaj_ZwracaSume()
    {
        Assert.Equal(5, Kalkulator.Dodaj(2, 3));
    }

    [Fact]
    public void Odejmij_ZwracaRoznice()
    {
        Assert.Equal(1, Kalkulator.Odejmij(3, 2));
    }

    [Fact]
    public void Mnoz_ZwracaIloczyn()
    {
        Assert.Equal(6, Kalkulator.Mnoz(2, 3));
    }

    [Fact]
    public void Dziel_ZwracaIloraz()
    {
        Assert.Equal(2.5, Kalkulator.Dziel(5, 2));
    }

    [Fact]
    public void Dziel_PrzezZero_RzucaWyjatek()
    {
        Assert.Throws<DivideByZeroException>(() => Kalkulator.Dziel(5, 0));
    }

    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(5, 0, 1)]
    [InlineData(2, -1, 0.5)]
    public void Poteguj_ZwracaPoprawnyWynik(double a, double b, double oczekiwany)
    {
        Assert.Equal(oczekiwany, Kalkulator.Poteguj(a, b));
    }
}