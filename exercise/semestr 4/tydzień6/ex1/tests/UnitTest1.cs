public class LoggerTests : IDisposable
{
    public void Dispose() => Logger.Reset();

    [Fact]
    public void Instancja_ZwracaTenSamObiekt()
    {
        var a = Logger.Instancja;
        var b = Logger.Instancja;
        Assert.Same(a, b);
    }

    [Fact]
    public void Zapisz_DodajeLog()
    {
        Logger.Instancja.Zapisz("test");
        Assert.NotEmpty(Logger.Instancja.PobierzLogi());
    }

    [Fact]
    public void PobierzLogi_ZawieraZapisanyKomunikat()
    {
        Logger.Instancja.Zapisz("hello world");
        Assert.True(Logger.Instancja.PobierzLogi().Any(l => l.Contains("hello world")));
    }
}
