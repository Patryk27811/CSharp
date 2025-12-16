using Xunit;

public class DniTygodniaTests
{
    [Theory]
    [InlineData(DzienTygodnia.Poniedzialek, false)]
    [InlineData(DzienTygodnia.Sroda, false)]
    [InlineData(DzienTygodnia.Piatek, false)]
    [InlineData(DzienTygodnia.Sobota, true)]
    [InlineData(DzienTygodnia.Niedziela, true)]
    public void CzyWeekend_ZwracaPoprawnyWynik(DzienTygodnia dzien, bool oczekiwanyWynik)
    {
        bool wynik = Kalendarz.CzyWeekend(dzien);
        Assert.Equal(oczekiwanyWynik, wynik);
    }

    [Fact]
    public void Enum_MaPoprawneWartosciLiczbowe()
    {
        Assert.Equal(1, (int)DzienTygodnia.Poniedzialek);
        Assert.Equal(7, (int)DzienTygodnia.Niedziela);
    }
}