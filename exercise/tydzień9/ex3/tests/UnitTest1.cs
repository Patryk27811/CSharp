using Xunit;

public class WektorTests
{
    [Fact]
    public void OperatorPlus_DodajeDwaWektoryPoprawnie()
    {
        var w1 = new Wektor2D(2.0, 3.0);
        var w2 = new Wektor2D(4.0, 5.0);

        var wynik = w1 + w2;

        Assert.Equal(6.0, wynik.X);
        Assert.Equal(8.0, wynik.Y);
    }

    [Fact]
    public void OperatorPlus_ObslugujeWartosciUjemne()
    {
        var w1 = new Wektor2D(10.0, -5.0);
        var w2 = new Wektor2D(-3.0, -2.0);

        var wynik = w1 + w2;

        Assert.Equal(7.0, wynik.X);
        Assert.Equal(-7.0, wynik.Y);
    }

    [Fact]
    public void OperatorPlus_NieModyfikujeOryginalnychWektorow()
    {
        var w1 = new Wektor2D(1.0, 1.0);
        var w2 = new Wektor2D(2.0, 2.0);

        var wynik = w1 + w2;

        Assert.Equal(1.0, w1.X);
        Assert.Equal(2.0, w2.X);
    }
    
    [Fact]
    public void ToString_ZwracaPoprawnyFormat()
    {
        var w = new Wektor2D(5.5, 0);
        
        Assert.Equal("[5,5, 0]", w.ToString());
    }
}