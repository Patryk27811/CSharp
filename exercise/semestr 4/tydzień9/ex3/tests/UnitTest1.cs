using System.IO.Compression;

public class ZipHelperTests : IDisposable
{
    private readonly string _folder;
    private readonly string _zip;

    public ZipHelperTests()
    {
        _folder = Path.Combine(Path.GetTempPath(), "zip_test_" + Guid.NewGuid().ToString("N"));
        _zip = Path.GetTempFileName() + ".zip";
        Directory.CreateDirectory(_folder);
        File.WriteAllText(Path.Combine(_folder, "a.txt"), "aaa");
        File.WriteAllText(Path.Combine(_folder, "b.txt"), "bbb");
    }

    public void Dispose()
    {
        if (Directory.Exists(_folder)) Directory.Delete(_folder, true);
        if (File.Exists(_zip)) File.Delete(_zip);
    }

    [Fact]
    public void SpakujFolder_TworzeZip()
    {
        ZipHelper.SpakujFolder(_folder, _zip);
        Assert.True(File.Exists(_zip));
    }

    [Fact]
    public void ListaZawartosci_ZwracaWszystkiePliki()
    {
        ZipHelper.SpakujFolder(_folder, _zip);
        var zawartosc = ZipHelper.ListaZawartosci(_zip);
        Assert.Equal(2, zawartosc.Count);
    }

    [Fact]
    public void SpakujFolder_RzucaWyjatek_GdyFolderNieIstnieje()
    {
        Assert.Throws<DirectoryNotFoundException>(() =>
            ZipHelper.SpakujFolder("nieistniejacy_folder", _zip));
    }

    [Fact]
    public void RozmiarZip_ZwracaLiczbeDodatnia()
    {
        ZipHelper.SpakujFolder(_folder, _zip);
        Assert.True(ZipHelper.RozmiarZip(_zip) > 0);
    }
}
