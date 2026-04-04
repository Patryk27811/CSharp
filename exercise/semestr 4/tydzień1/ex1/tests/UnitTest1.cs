using System.Linq;

public class ParzysteLiczbyTests
{
    private static int[] WybierzParzyste(int[] liczby) =>
        liczby.Where(n => n % 2 == 0).ToArray();

    [Fact]
    public void WybierzParzyste_ZwracaTylkoParzyste()
    {
        int[] wejscie = { 1, 2, 3, 4, 5, 6 };
        var wynik = WybierzParzyste(wejscie);
        Assert.Equal(new[] { 2, 4, 6 }, wynik);
    }

    [Fact]
    public void WybierzParzyste_BrakParzystych_ZwracaPusta()
    {
        int[] wejscie = { 1, 3, 5 };
        var wynik = WybierzParzyste(wejscie);
        Assert.Empty(wynik);
    }

    [Fact]
    public void WybierzParzyste_ZawieraZero()
    {
        int[] wejscie = { 0, 1, 2 };
        var wynik = WybierzParzyste(wejscie);
        Assert.Contains(0, wynik);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8 }, 4)]
    [InlineData(new int[] { 1, 3, 5, 7 }, 0)]
    [InlineData(new int[] { 10, 20, 30 }, 3)]
    public void WybierzParzyste_PoprawnaLiczbaElementow(int[] wejscie, int oczekiwanaLiczba)
    {
        var wynik = WybierzParzyste(wejscie);
        Assert.Equal(oczekiwanaLiczba, wynik.Length);
    }
}
