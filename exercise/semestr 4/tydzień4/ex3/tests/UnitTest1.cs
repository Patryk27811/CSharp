public class BezpiecznyKlientTests
{
    [Fact]
    public async Task PobierzBezpiecznieAsync_ZwracaSukces()
    {
        var wynik = await BezpiecznyKlient.PobierzBezpiecznieAsync("https://test.com");
        Assert.Contains("Sukces", wynik);
    }

    [Fact]
    public async Task PobierzBezpiecznieAsync_RzucaBladApiException_GdySymulacjaBlad()
    {
        await Assert.ThrowsAsync<BladApiException>(
            () => BezpiecznyKlient.PobierzBezpiecznieAsync("https://test.com", symulujBlad: true));
    }

    [Fact]
    public async Task PobierzBezpiecznieAsync_RzucaArgumentException_DlaPustegoUrl()
    {
        await Assert.ThrowsAsync<ArgumentException>(
            () => BezpiecznyKlient.PobierzBezpiecznieAsync(""));
    }

    [Fact]
    public void BladApiException_ZawieraKodStatusu()
    {
        var ex = new BladApiException("test", 404);
        Assert.Equal(404, ex.KodStatusu);
    }
}
