using System;
using Geometria; 
using Xunit;

namespace Geometria.Tests
{
    
    public class ProstokatTests
    {
        [Theory]
        [InlineData(4.0, 6.0, 24.0, 20.0)] 
        [InlineData(10.0, 2.0, 20.0, 24.0)] 
        [InlineData(5.0, 5.0, 25.0, 20.0)] 
        [InlineData(1.5, 3.0, 4.5, 9.0)]
        public void Prostokat_ObliczaPoleIObwod_Poprawnie(double szerokosc, double wysokosc, double oczekiwanePole, double oczekiwanyObwod)
        {
           
            var prostokat = new Prostokat(szerokosc, wysokosc);

            Assert.Equal(oczekiwanePole, prostokat.Pole);
            Assert.Equal(oczekiwanyObwod, prostokat.Obwod);
        }

        [Theory]
        [InlineData(0, 10)] 
        [InlineData(10, 0)]  
        [InlineData(-5, 10)] 
        [InlineData(10, -5)] 
        public void Prostokat_Konstruktor_RzucaWyjatek_DlaNiepoprawnychDanych(double szerokosc, double wysokosc)
        {
            Assert.Throws<ArgumentException>(() => new Prostokat(szerokosc, wysokosc));
        }
    }

 
    public class KoloTests
    {
        [Theory]
        
        [InlineData(1.0, Math.PI, 2 * Math.PI)] 
        [InlineData(5.0, 78.539816, 31.415927)] 
        [InlineData(1.5, 7.068583, 9.424778)]         public void Kolo_ObliczaPoleIObwod_Poprawnie(double promien, double oczekiwanePole, double oczekiwanyObwod)
        {
            
            var kolo = new Kolo(promien);

            Assert.Equal(oczekiwanePole, kolo.Pole, 6);
            Assert.Equal(oczekiwanyObwod, kolo.Obwod, 6);
        }

        [Theory]
        [InlineData(0)] 
        [InlineData(-10)] 
        public void Kolo_Konstruktor_RzucaWyjatek_DlaNiepoprawnegoPromienia(double promien)
        {
            Assert.Throws<ArgumentException>(() => new Kolo(promien));
        }
    }
}