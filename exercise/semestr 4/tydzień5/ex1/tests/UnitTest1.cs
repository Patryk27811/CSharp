public class StoperTests
{
    [Fact]
    public async Task ZmierzCzasAsync_ZwracaNieuJemnyTimeSpan()
    {
        var czas = await Stoper.ZmierzCzasAsync(async () => await Task.Delay(50));
        Assert.True(czas.TotalMilliseconds >= 0);
    }

    [Fact]
    public async Task ZmierzCzasAsync_WykonujeOperacje()
    {
        bool wykonano = false;
        await Stoper.ZmierzCzasAsync(async () =>
        {
            await Task.CompletedTask;
            wykonano = true;
        });
        Assert.True(wykonano);
    }

    [Fact]
    public async Task ZmierzCzasAsync_RzucaWyjatek_DlaNullOperacji()
    {
        await Assert.ThrowsAsync<ArgumentNullException>(
            () => Stoper.ZmierzCzasAsync(null!));
    }
}
