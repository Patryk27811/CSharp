using Xunit;

namespace SilniaRekurencyjna.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(5, 120)]
        public void ObliczSilnie_ZwracaPoprawnyWynik(int n, long oczekiwany)
        {
            Assert.Equal(oczekiwany, SilniaRekurencyjna.Program.ObliczSilnie(n));
        }
    }
}
