using System;
using Xunit;

public class KontoTests
{
    [Fact]
    public void Wyplac_RzucaWyjatek_GdyKwotaPrzekraczaSaldo()
    {
        var konto = new KontoBankowe("Test", 100m);
        decimal kwotaZaDuza = 150m;

        Assert.Throws<InvalidOperationException>(() => konto.Wyplac(kwotaZaDuza));
    }

    [Fact]
    public void Wyplac_ZmniejszaSaldo_GdyKwotaJestPoprawna()
    {
        var konto = new KontoBankowe("Test", 100m);
        konto.Wyplac(100m);

        Assert.Equal(0m, konto.Saldo);
    }
}