using Xunit;

namespace TablicaSrednia.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5.5)]
        [InlineData(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, 10)]
        public void ObliczSrednia_ZwracaPoprawnyWynik(int[] dane, double oczekiwany)
        {
            Assert.Equal(oczekiwany, TablicaSrednia.Program.ObliczSrednia(dane));
        }
    }
}
