using System.Text.Json;

public class JsonValidatorTests
{
    private TodoItemFull PrzykladowyItem() =>
        new(1, "Test", false, new DateTime(2024, 1, 1), "Opis");

    [Fact]
    public void Serializuj_ZwracaNiepustyJson()
    {
        var json = JsonValidator.Serializuj(PrzykladowyItem());
        Assert.False(string.IsNullOrEmpty(json));
    }

    [Fact]
    public void Serializuj_ZwracaPoprawnyJson()
    {
        var json = JsonValidator.Serializuj(PrzykladowyItem());
        Assert.Contains("\"Tytul\"", json);
        Assert.Contains("\"Test\"", json);
    }

    [Fact]
    public void Deserializuj_OdtwarzaPopyraneDane()
    {
        var oryginal = PrzykladowyItem();
        var json = JsonValidator.Serializuj(oryginal);
        var odtworzony = JsonValidator.Deserializuj(json);

        Assert.Equal(oryginal.Id, odtworzony!.Id);
        Assert.Equal(oryginal.Tytul, odtworzony.Tytul);
        Assert.Equal(oryginal.Ukonczone, odtworzony.Ukonczone);
    }

    [Fact]
    public void CzySerializacjaPoprawna_ZwracaTrue_DlaPoprawnegoPrzykladu()
    {
        Assert.True(JsonValidator.CzySerializacjaPoprawna(PrzykladowyItem()));
    }

    [Fact]
    public void Serializuj_RzucaWyjatek_DlaNulla()
    {
        Assert.Throws<ArgumentNullException>(() => JsonValidator.Serializuj(null!));
    }

    [Fact]
    public void Deserializuj_RzucaWyjatek_DlaPustegoJson()
    {
        Assert.Throws<ArgumentException>(() => JsonValidator.Deserializuj(""));
    }

    [Fact]
    public void SerializacjaOkrazna_ZachowujeOpis()
    {
        var item = new TodoItemFull(5, "Z opisem", true, DateTime.Now, "Mój opis");
        var json = JsonValidator.Serializuj(item);
        var odtworzony = JsonValidator.Deserializuj(json);
        Assert.Equal("Mój opis", odtworzony?.Opis);
    }
}
