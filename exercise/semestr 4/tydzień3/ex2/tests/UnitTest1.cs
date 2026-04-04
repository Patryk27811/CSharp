using System.Text.Json;

public class JsonCzytnikTests
{
    [Fact]
    public void WczytajJson_DeserializujePoprawnieNazwe()
    {
        string json = """{"Nazwa":"Test","Wersja":"2.0","DebugMode":false}""";
        var wynik = JsonCzytnik.WczytajJson<KonfigAplkikacji>(json);
        Assert.Equal("Test", wynik!.Nazwa);
    }

    [Fact]
    public void WczytajJson_DeserializujePoprawneBool()
    {
        string json = """{"Nazwa":"X","Wersja":"1","DebugMode":true}""";
        var wynik = JsonCzytnik.WczytajJson<KonfigAplkikacji>(json);
        Assert.True(wynik!.DebugMode);
    }

    [Fact]
    public void WczytajJson_RzucaWyjatek_DlaPustegoJson()
    {
        Assert.Throws<ArgumentException>(() => JsonCzytnik.WczytajJson<KonfigAplkikacji>(""));
    }
}
