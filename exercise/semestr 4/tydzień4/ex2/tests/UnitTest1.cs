public class RownoleglePobieranieTests
{
    [Fact]
    public async Task PobierzRownolegleAsync_ZwracaTakaSamaLiczbeWynikow()
    {
        var urls = new List<string> { "http://a.com", "http://b.com", "http://c.com" };
        var wyniki = await RownoleglePobieranie.PobierzRownolegleAsync(urls);
        Assert.Equal(3, wyniki.Count);
    }

    [Fact]
    public async Task PobierzRownolegleAsync_WszystkieWynikiNiepuste()
    {
        var urls = new List<string> { "http://a.com", "http://b.com" };
        var wyniki = await RownoleglePobieranie.PobierzRownolegleAsync(urls);
        Assert.All(wyniki, w => Assert.False(string.IsNullOrEmpty(w)));
    }

    [Fact]
    public async Task PobierzRownolegleAsync_RzucaWyjatek_DlaPustejListy()
    {
        await Assert.ThrowsAsync<ArgumentException>(
            () => RownoleglePobieranie.PobierzRownolegleAsync(new List<string>()));
    }

    [Fact]
    public async Task PobierzRownolegleAsync_ZwracaPoprawneMiejscePliku()
    {
        var urls = new List<string> { "http://test.com" };
        var wyniki = await RownoleglePobieranie.PobierzRownolegleAsync(urls);
        Assert.Contains("http://test.com", wyniki[0]);
    }
}
