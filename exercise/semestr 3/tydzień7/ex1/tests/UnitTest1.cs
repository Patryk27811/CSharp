using System;
using System.Collections.Generic;
using Xunit;

public class DziennikTests
{
    [Fact]
    public void DodajOcene_DodajeNowyPrzedmiot()
    {
        var dziennik = new Dziennik();
        dziennik.DodajOcene("Chemia", 5);
        
        int ocena = dziennik.PobierzOcene("Chemia");
        
        Assert.Equal(5, ocena);
    }

    [Fact]
    public void DodajOcene_AktualizujeIstniejacyPrzedmiot()
    {
        var dziennik = new Dziennik();
        dziennik.DodajOcene("Informatyka", 3);
        dziennik.DodajOcene("Informatyka", 5); 

        int ocena = dziennik.PobierzOcene("Informatyka");

        Assert.Equal(5, ocena);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(7)]
    [InlineData(-1)]
    public void DodajOcene_RzucaWyjatek_GdyOcenaSpozaSkali(int blednaOcena)
    {
        var dziennik = new Dziennik();
        Assert.Throws<ArgumentException>(() => dziennik.DodajOcene("WF", blednaOcena));
    }

    [Fact]
    public void ObliczSrednia_ZwracaPoprawnyWynik()
    {
        var dziennik = new Dziennik();
        dziennik.DodajOcene("A", 4);
        dziennik.DodajOcene("B", 6);
        dziennik.DodajOcene("C", 2);

        double srednia = dziennik.ObliczSrednia();

        Assert.Equal(4.0, srednia);
    }
}