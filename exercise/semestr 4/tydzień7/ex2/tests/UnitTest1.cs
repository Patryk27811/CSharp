using System.Text.Json;

public class JsonDeserializatorTests
{
    [Fact]
    public void DeserializujListe_ZwracaPoprawneLiczbePozycji()
    {
        string json = """[{"id":1,"userId":1,"title":"T1","body":"B1"},{"id":2,"userId":1,"title":"T2","body":"B2"}]""";
        var wynik = JsonDeserializator.DeserializujListe<PostApi>(json);
        Assert.Equal(2, wynik.Count);
    }

    [Fact]
    public void DeserializujListe_DeserializujePolaPoprawnie()
    {
        string json = """[{"id":42,"userId":5,"title":"Test","body":"Treść"}]""";
        var wynik = JsonDeserializator.DeserializujListe<PostApi>(json);
        Assert.Equal(42, wynik[0].Id);
        Assert.Equal("Test", wynik[0].Title);
    }

    [Fact]
    public void DeserializujListe_PustaTablica_ZwracaPusta()
    {
        var wynik = JsonDeserializator.DeserializujListe<PostApi>("[]");
        Assert.Empty(wynik);
    }

    [Fact]
    public void DeserializujListe_RzucaWyjatek_DlaPustegoJson()
    {
        Assert.Throws<ArgumentException>(() =>
            JsonDeserializator.DeserializujListe<PostApi>(""));
    }
}
