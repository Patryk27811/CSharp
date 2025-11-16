using System;
using Xunit;

namespace TestyUzytkownika
{
    public class UserTests
    {
        [Fact]
        public void UstawienieWieku_RzucaWyjatek_GdyWiekJestNiedozwolony()
        {
            User uzytkownik = new User();
            int niepoprawnyWiek = -5;

            Assert.Throws<InvalidAgeException>(() => 
            {
                uzytkownik.Age = niepoprawnyWiek;
            });
        }

        [Fact]
        public void UstawienieWieku_ZapisujeWartosc_GdyWiekJestPoprawny()
        {
            User uzytkownik = new User();
            int poprawnyWiek = 30;

            uzytkownik.Age = poprawnyWiek;

            Assert.Equal(poprawnyWiek, uzytkownik.Age);
        }
    }
}