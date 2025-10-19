using Xunit;

namespace CzyPierwsza.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(17, true)]
        [InlineData(18, false)]
        [InlineData(1, false)]
        [InlineData(0, false)]
        public void IsPrime_ZwracaPoprawnyWynik(int n, bool oczekiwany)
        {
            Assert.Equal(oczekiwany, CzyPierwsza.Program.IsPrime(n));
        }
    }
}
