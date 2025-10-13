using Xunit;

public class SampleTests
{
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(-1, 1, 0)]
    [InlineData(10, -3, 7)]
    public void Add_Works(int a, int b, int expected)
    {
        Assert.Equal(expected, a + b);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(0, 5, -5)]
    [InlineData(-2, -2, 0)]
    public void Sub_Works(int a, int b, int expected)
    {
        Assert.Equal(expected, a - b);
    }
}

