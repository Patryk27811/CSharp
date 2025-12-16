using Xunit;

public class KonwerterTests
{
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)] 
    [InlineData(37, 98.6)]
    public void CelsjuszNaFahrenheit_ZwracaPoprawnyWynik(double c, double oczekiwaneF)
    {
        double wynik = Konwerter.CelsjuszNaFahrenheit(c);
        Assert.Equal(oczekiwaneF, wynik, 1); // Tolerancja do 1 miejsca po przecinku
    }

    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    [InlineData(-40, -40)]
    [InlineData(98.6, 37)]
    public void FahrenheitNaCelsjusz_ZwracaPoprawnyWynik(double f, double oczekiwaneC)
    {
        double wynik = Konwerter.FahrenheitNaCelsjusz(f);
        Assert.Equal(oczekiwaneC, wynik, 1);
    }
}