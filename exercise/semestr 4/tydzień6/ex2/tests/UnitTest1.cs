public class KsztaltFactoryTests
{
    [Fact]
    public void Utworz_TworzeOkrag()
    {
        var k = KsztaltFactory.Utworz("okrag", 1.0);
        Assert.Equal("Okrąg", k.Nazwa);
    }

    [Fact]
    public void Utworz_TworzeProstokat()
    {
        var k = KsztaltFactory.Utworz("prostokat", 3.0, 4.0);
        Assert.Equal("Prostokąt", k.Nazwa);
    }

    [Fact]
    public void Okrag_ObliczaPoprawnePole()
    {
        var k = KsztaltFactory.Utworz("circle", 1.0);
        Assert.Equal(Math.PI, k.Pole(), 5);
    }

    [Fact]
    public void Prostokat_ObliczaPoprawnePole()
    {
        var k = KsztaltFactory.Utworz("rectangle", 3.0, 4.0);
        Assert.Equal(12.0, k.Pole(), 5);
    }

    [Fact]
    public void Utworz_RzucaWyjatek_DlaNieznanego()
    {
        Assert.Throws<ArgumentException>(() => KsztaltFactory.Utworz("trojkat", 3.0));
    }

    [Fact]
    public void Okrag_RzucaWyjatek_GdyPromienUjemny()
    {
        Assert.Throws<ArgumentException>(() => KsztaltFactory.Utworz("okrag", -1.0));
    }
}
