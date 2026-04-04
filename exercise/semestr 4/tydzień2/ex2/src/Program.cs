using System.Linq;

public static class Program
{
    public static List<string> SortujMalejaco(List<string> lista)
    {
        if (lista == null)
            throw new ArgumentNullException(nameof(lista));

        return lista.OrderByDescending(s => s).ToList();
    }

    static void Main()
    {
        var slowa = new List<string> { "banan", "jabłko", "ananas", "wiśnia", "gruszka" };
        var posortowane = SortujMalejaco(slowa);

        Console.WriteLine("Posortowane malejąco:");
        foreach (var s in posortowane)
            Console.WriteLine(s);
    }
}
