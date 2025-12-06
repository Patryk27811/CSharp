using System;
using Xunit;

public class GrupaTests
{
    [Fact]
    public void ObliczSrednia_ZwracaPoprawnyWynik_DlaKilkuStudentow()
    {
        var grupa = new GrupaStudencka("Testowa");
        grupa.DodajStudenta(new Student("S1", 3.0));
        grupa.DodajStudenta(new Student("S2", 5.0)); // Średnia 4.0

        double wynik = grupa.ObliczSrednia();

        Assert.Equal(4.0, wynik);
    }

    [Fact]
    public void ObliczSrednia_ZwracaZero_DlaPustejGrupy()
    {
        var grupa = new GrupaStudencka("Pusta");

        double wynik = grupa.ObliczSrednia();

        Assert.Equal(0.0, wynik);
    }

    [Fact]
    public void DodajStudenta_ZwiekszaLiczbeStudentow()
    {
        var grupa = new GrupaStudencka("Testowa");
        grupa.DodajStudenta(new Student("Jan", 4.0));

        Assert.Single(grupa.PobierzStudentow());
    }

    [Theory]
    [InlineData(1.0)]
    [InlineData(7.0)]
    public void Student_RzucaWyjatek_GdyOcenaSpozaZakresu(double blednaOcena)
    {
        Assert.Throws<ArgumentException>(() => new Student("Test", blednaOcena));
    }
}