using System;
using Xunit;

public class KontoBankoweTests
{
    [Fact]
    public void Wplac_ZwiekszaSaldo_GdyKwotaJestPoprawna()
    {
        var konto = new KontoBankowe("Test", 100m);
        konto.Wplac(50m);
        Assert.Equal(150m, konto.Saldo);
    }

    [Fact]
    public void Wyplac_ZmniejszaSaldo_GdySrodkiSaWystarczajace()
    {
        var konto = new KontoBankowe("Test", 100m);
        konto.Wyplac(40m);
        Assert.Equal(60m, konto.Saldo);
    }

    [Fact]
    public void Wyplac_RzucaWyjatek_GdyBrakSrodkow()
    {
        var konto = new KontoBankowe("Test", 50m);
        Assert.Throws<InvalidOperationException>(() => konto.Wyplac(100m));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-10)]
    public void Wplac_RzucaWyjatek_GdyKwotaJestNiepoprawna(decimal kwota)
    {
        var konto = new KontoBankowe("Test", 100m);
        Assert.Throws<ArgumentException>(() => konto.Wplac(kwota));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-10)]
    public void Wyplac_RzucaWyjatek_GdyKwotaJestNiepoprawna(decimal kwota)
    {
        var konto = new KontoBankowe("Test", 100m);
        Assert.Throws<ArgumentException>(() => konto.Wyplac(kwota));
    }
}