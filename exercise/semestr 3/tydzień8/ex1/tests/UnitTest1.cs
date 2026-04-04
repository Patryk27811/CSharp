using Xunit;

public class WeryfikatorTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("[]", true)]
    [InlineData("{}", true)]
    [InlineData("(a + b) * [c - d]", true)]
    [InlineData("{[()]}", true)]
    [InlineData("((()))", true)]
    [InlineData("", true)]
    [InlineData("(", false)]
    [InlineData(")", false)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)] 
    [InlineData("((", false)]
    [InlineData("{[}", false)]
    public void Sprawdz_ZwracaPoprawnyWynik(string wejscie, bool oczekiwanyWynik)
    {
        bool wynik = WeryfikatorNawiasow.Sprawdz(wejscie);
        Assert.Equal(oczekiwanyWynik, wynik);
    }
}