using Moq;

public class ProduktServiceTests
{
    [Fact]
    public void PobierzPodsumowanie_WywolujeRepozytorium()
    {
        var mockRepo = new Mock<IProduktRepository>();
        mockRepo.Setup(r => r.Liczba()).Returns(2);
        mockRepo.Setup(r => r.PobierzNazwy()).Returns(new List<string> { "A", "B" });

        var service = new ProduktService(mockRepo.Object);
        string wynik = service.PobierzPodsumowanie();

        mockRepo.Verify(r => r.Liczba(), Times.Once);
        mockRepo.Verify(r => r.PobierzNazwy(), Times.Once);
    }

    [Fact]
    public void PobierzPodsumowanie_ZawieraLiczbeProduktow()
    {
        var mockRepo = new Mock<IProduktRepository>();
        mockRepo.Setup(r => r.Liczba()).Returns(3);
        mockRepo.Setup(r => r.PobierzNazwy()).Returns(new List<string> { "X", "Y", "Z" });

        var service = new ProduktService(mockRepo.Object);
        string wynik = service.PobierzPodsumowanie();

        Assert.Contains("3", wynik);
    }

    [Fact]
    public void Konstruktor_RzucaWyjatek_DlaNullRepo()
    {
        Assert.Throws<ArgumentNullException>(() => new ProduktService(null!));
    }
}
