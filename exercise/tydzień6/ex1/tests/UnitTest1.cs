using Xunit;

public class PalindromeTests
{
    [Theory]
    [InlineData("kajak", true)]
    [InlineData("Kajak", true)]
    [InlineData("radar", true)]
    [InlineData("potop", true)]
    [InlineData("dom", false)]
    [InlineData("kot", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void IsPalindrome_ZwracaPoprawnyWynik(string? input, bool expected)
    {
        bool result = input.IsPalindrome();
        Assert.Equal(expected, result);
    }
}