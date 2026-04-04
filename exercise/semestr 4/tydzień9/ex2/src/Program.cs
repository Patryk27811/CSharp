using System.Xml.Linq;

public static class XmlParser
{
    public static List<string> WyciagnijTytuly(string xml)
    {
        if (string.IsNullOrWhiteSpace(xml))
            throw new ArgumentException("XML nie może być pusty.");

        var dokument = XDocument.Parse(xml);
        return dokument.Descendants("title")
            .Select(e => e.Value)
            .ToList();
    }
}

public class Program
{
    static void Main()
    {
        string xml = """
        <rss>
            <channel>
                <title>Kanał RSS</title>
                <item>
                    <title>Artykuł 1</title>
                    <description>Opis 1</description>
                </item>
                <item>
                    <title>Artykuł 2</title>
                    <description>Opis 2</description>
                </item>
            </channel>
        </rss>
        """;

        var tytuly = XmlParser.WyciagnijTytuly(xml);
        Console.WriteLine("Tytuly w XML:");
        foreach (var t in tytuly)
            Console.WriteLine($"  - {t}");
    }
}
