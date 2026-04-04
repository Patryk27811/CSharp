public class ApiKlientTests
{
    [Fact]
    public async Task PobierzDaneAsync_ZwracaOdpowiedz()
    {
        var wynik = await ApiKlient.PobierzDaneAsync("https://test.com");
        Assert.Contains("https://test.com", wynik);
    }

    [Fact]
    public async Task PobierzDaneAsync_ZwracaNiepustyString()
    {
        var wynik = await ApiKlient.PobierzDaneAsync("https://test.com");
        Assert.False(string.IsNullOrEmpty(wynik));
    }

    [Fact]
    public async Task PobierzDaneAsync_RzucaWyjatek_DlaPustegoUrl()
    {
        await Assert.ThrowsAsync<ArgumentException>(() => ApiKlient.PobierzDaneAsync(""));
    }
}
