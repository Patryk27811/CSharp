public class MatematykaPierwszaTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(5, true)]
    [InlineData(7, true)]
    [InlineData(11, true)]
    [InlineData(13, true)]
    [InlineData(17, true)]
    [InlineData(19, true)]
    public void CzyPierwsza_ZwracaTrue_DlaLiczbPierwszych(int n, bool oczekiwane)
    {
        Assert.Equal(oczekiwane, MatematykaPierwsza.CzyPierwsza(n));
    }

    [Theory]
    [InlineData(0, false)]
    [InlineData(1, false)]
    [InlineData(4, false)]
    [InlineData(6, false)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(15, false)]
    [InlineData(-5, false)]
    public void CzyPierwsza_ZwracaFalse_DlaLiczbNiePierwszych(int n, bool oczekiwane)
    {
        Assert.Equal(oczekiwane, MatematykaPierwsza.CzyPierwsza(n));
    }

    [Fact]
    public void ZnajdzPierwsze_ZwracaPoprawneLiczby()
    {
        var wynik = MatematykaPierwsza.ZnajdzPierwtze(10);
        Assert.Equal(new[] { 2, 3, 5, 7 }, wynik);
    }

    [Fact]
    public void ZnajdzPierwsze_PonizerDwa_ZwracaPusta()
    {
        var wynik = MatematykaPierwsza.ZnajdzPierwtze(1);
        Assert.Empty(wynik);
    }
}
