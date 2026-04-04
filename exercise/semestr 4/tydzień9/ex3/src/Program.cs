using System.IO.Compression;

public static class ZipHelper
{
    public static void SpakujFolder(string folderZrodlowy, string sciezkaZip)
    {
        if (!Directory.Exists(folderZrodlowy))
            throw new DirectoryNotFoundException($"Folder nie istnieje: {folderZrodlowy}");
        if (string.IsNullOrWhiteSpace(sciezkaZip))
            throw new ArgumentException("Ścieżka ZIP nie może być pusta.");
        if (File.Exists(sciezkaZip))
            File.Delete(sciezkaZip);

        ZipFile.CreateFromDirectory(folderZrodlowy, sciezkaZip);
        Console.WriteLine($"Spakowano folder '{folderZrodlowy}' do '{sciezkaZip}'.");
    }

    public static long RozmiarZip(string sciezkaZip)
    {
        if (!File.Exists(sciezkaZip))
            throw new FileNotFoundException($"Plik ZIP nie istnieje: {sciezkaZip}");
        return new FileInfo(sciezkaZip).Length;
    }

    public static List<string> ListaZawartosci(string sciezkaZip)
    {
        if (!File.Exists(sciezkaZip))
            throw new FileNotFoundException($"Plik ZIP nie istnieje: {sciezkaZip}");

        using var archiwum = ZipFile.OpenRead(sciezkaZip);
        return archiwum.Entries.Select(e => e.Name).ToList();
    }
}

public class Program
{
    static void Main()
    {
        string folder = Path.Combine(Path.GetTempPath(), "testFolder_" + Guid.NewGuid().ToString("N"));
        string zipSciezka = Path.GetTempFileName() + ".zip";
        Directory.CreateDirectory(folder);
        File.WriteAllText(Path.Combine(folder, "plik1.txt"), "Zawartość 1");
        File.WriteAllText(Path.Combine(folder, "plik2.txt"), "Zawartość 2");

        ZipHelper.SpakujFolder(folder, zipSciezka);
        Console.WriteLine($"Rozmiar ZIP: {ZipHelper.RozmiarZip(zipSciezka)} bajtów");
        Console.WriteLine("Zawartość:");
        foreach (var plik in ZipHelper.ListaZawartosci(zipSciezka))
            Console.WriteLine($"  - {plik}");

        Directory.Delete(folder, recursive: true);
        File.Delete(zipSciezka);
    }
}
