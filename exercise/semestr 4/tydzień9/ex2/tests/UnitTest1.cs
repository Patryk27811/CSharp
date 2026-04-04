public class XmlParserTests
{
    [Fact]
    public void WyciagnijTytuly_ZwracaWszystkieTytuly()
    {
        string xml = "<root><title>A</title><title>B</title><title>C</title></root>";
        var wynik = XmlParser.WyciagnijTytuly(xml);
        Assert.Equal(3, wynik.Count);
    }

    [Fact]
    public void WyciagnijTytuly_ZwracaPoprawneTytuly()
    {
        string xml = "<root><item><title>Hello</title></item></root>";
        var wynik = XmlParser.WyciagnijTytuly(xml);
        Assert.Contains("Hello", wynik);
    }

    [Fact]
    public void WyciagnijTytuly_BezTytulow_ZwracaPusta()
    {
        string xml = "<root><item><desc>nic</desc></item></root>";
        var wynik = XmlParser.WyciagnijTytuly(xml);
        Assert.Empty(wynik);
    }

    [Fact]
    public void WyciagnijTytuly_RzucaWyjatek_DlaPustegoXml()
    {
        Assert.Throws<ArgumentException>(() => XmlParser.WyciagnijTytuly(""));
    }
}
