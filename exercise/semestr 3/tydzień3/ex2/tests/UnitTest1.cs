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
        public void Rectangle_ObliczaPoleIObwod(double w, double h, double expectedArea, double expectedPerimeter)
        {
            var rect = new Rectangle(w, h);
            Assert.Equal(expectedArea, rect.Area());
            Assert.Equal(expectedPerimeter, rect.Perimeter());
        }
    }
}

