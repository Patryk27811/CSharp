using Xunit;

public class AnalizatorTests
{
    [Fact]
    public void Analizuj_ZwracaZera_DlaPustegoTekstu()
    {
        var wynik = AnalizatorTekstu.Analizuj("");

        Assert.Equal(0, wynik.LiczbaZnakow);
        Assert.Equal(0, wynik.LiczbaSlow);
        Assert.Equal(0, wynik.LiczbaLinii);
    }

    [Fact]
    public void Analizuj_LiczyPoprawnie_ProsteZdanie()
    {
        string tekst = "Ala ma kota";
        
        var wynik = AnalizatorTekstu.Analizuj(tekst);

        Assert.Equal(11, wynik.LiczbaZnakow);
        Assert.Equal(3, wynik.LiczbaSlow);
        Assert.Equal(1, wynik.LiczbaLinii);
    }

    [Fact]
    public void Analizuj_LiczyPoprawnie_WieleLinii()
    {
        string tekst = "Linia pierwsza\nLinia druga";
        
        var wynik = AnalizatorTekstu.Analizuj(tekst);

        // "Linia pierwsza" (14) + "\n" (1) + "Linia druga" (11) = 26
        Assert.Equal(26, wynik.LiczbaZnakow);
        Assert.Equal(4, wynik.LiczbaSlow);
        Assert.Equal(2, wynik.LiczbaLinii);
    }

    [Fact]
    public void Analizuj_IgnorujeWielokrotneSpacjePrzyLiczeniuSlow()
    {
        string tekst = "Jeden   Dwa    Trzy";
        
        var wynik = AnalizatorTekstu.Analizuj(tekst);

        Assert.Equal(3, wynik.LiczbaSlow);
    }
}