using Xunit;
using ProstokatApp;

namespace ProstokatApp.Tests
{
    public class RectangleTests
    {
        [Theory]
        [InlineData(2, 3, 6, 10)]
        [InlineData(5, 5, 25, 20)]
        [InlineData(10, 2, 20, 24)]
        public void Rectangle_KonstruktorUstawiaWymiaryIPrawidloweWyniki(
            double width, double height, double expectedArea, double expectedPerimeter)
        {
            var rect = new Rectangle(width, height);

            Assert.Equal(width, rect.Width);
            Assert.Equal(height, rect.Height);
            Assert.Equal(expectedArea, rect.Area());
            Assert.Equal(expectedPerimeter, rect.Perimeter());
        }
    }
}

