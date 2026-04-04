using System.Text.Json;

public class TodoManagerTests
{
    [Fact]
    public void Dodaj_ZwracaTodoZId()
    {
        var m = new TodoManager();
        var t = m.Dodaj("Test");
        Assert.True(t.Id > 0);
        Assert.Equal("Test", t.Tytul);
        Assert.False(t.Ukonczone);
    }

    [Fact]
    public void Ukoncz_ZmieniaStatus()
    {
        var m = new TodoManager();
        var t = m.Dodaj("Zadanie");
        m.Ukoncz(t.Id);
        Assert.True(m.PobierzWszystkie().First(x => x.Id == t.Id).Ukonczone);
    }

    [Fact]
    public void Ukoncz_ZwracaFalse_GdyNieIstnieje()
    {
        var m = new TodoManager();
        Assert.False(m.Ukoncz(999));
    }

    [Fact]
    public void Dodaj_RzucaWyjatek_GdyTytulPusty()
    {
        var m = new TodoManager();
        Assert.Throws<ArgumentException>(() => m.Dodaj(""));
    }
}
