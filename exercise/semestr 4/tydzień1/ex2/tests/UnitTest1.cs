using System.Linq;

public class SredniaTests
{
    private static double ObliczSrednia(int[] liczby)
    {
        if (liczby == null || liczby.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta.");
        return liczby.Average();
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6 }, 4.0)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3.0)]
    [InlineData(new int[] { 10 }, 10.0)]
    public void ObliczSrednia_ZwracaPoprawnyWynik(int[] liczby, double oczekiwana)
    {
        Assert.Equal(oczekiwana, ObliczSrednia(liczby), 5);
    }

    [Fact]
    public void ObliczSrednia_RzucaWyjatek_DlaPustejTablicy()
    {
        Assert.Throws<ArgumentException>(() => ObliczSrednia(Array.Empty<int>()));
    }

    [Fact]
    public void ObliczSrednia_RzucaWyjatek_DlaNulla()
    {
        Assert.Throws<ArgumentException>(() => ObliczSrednia(null!));
    }
}
