using System;
using Xunit;

public class KalkulatorTests
{
    [Fact]
    public void Oblicz_Dodawanie_ZwracaPoprawnyWynik()
    {
        string wyrazenie = "3 4 +";
        double wynik = KalkulatorRPN.Oblicz(wyrazenie);
        Assert.Equal(7, wynik);
    }

    [Fact]
    public void Oblicz_ZlozoneWyrazenie_ZwracaPoprawnyWynik()
    {
        string wyrazenie = "5 1 2 + 4 * + 3 -";
        double wynik = KalkulatorRPN.Oblicz(wyrazenie);
        Assert.Equal(14, wynik);
    }

    [Fact]
    public void Oblicz_Dzielenie_ZwracaPoprawnyWynik()
    {
        string wyrazenie = "12 3 /";
        double wynik = KalkulatorRPN.Oblicz(wyrazenie);
        Assert.Equal(4, wynik);
    }

    [Fact]
    public void Oblicz_LiczbyUjemne_ZwracaPoprawnyWynik()
    {
        string wyrazenie = "-5 3 +";
        double wynik = KalkulatorRPN.Oblicz(wyrazenie);
        Assert.Equal(-2, wynik);
    }

    [Fact]
    public void Oblicz_ZaMaloLiczb_RzucaWyjatek()
    {
        string wyrazenie = "5 +";
        Assert.Throws<InvalidOperationException>(() => KalkulatorRPN.Oblicz(wyrazenie));
    }

    [Fact]
    public void Oblicz_DzieleniePrzezZero_RzucaWyjatek()
    {
        string wyrazenie = "10 0 /";
        Assert.Throws<DivideByZeroException>(() => KalkulatorRPN.Oblicz(wyrazenie));
    }
}