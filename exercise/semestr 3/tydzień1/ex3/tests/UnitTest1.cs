using Xunit;

public class ParzystoscTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(0, true)]
    [InlineData(-4, true)]
    [InlineData(-7, false)]
    public void CzyParzysta_DzialaPoprawnie(int liczba, bool expected)
    {
        Assert.Equal(expected, Program.CzyParzysta(liczba));
    }
}
