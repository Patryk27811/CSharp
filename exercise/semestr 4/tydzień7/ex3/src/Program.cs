public static class MatematykaPierwsza
{
    public static bool CzyPierwsza(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(n); i += 2)
            if (n % i == 0) return false;

        return true;
    }

    public static List<int> ZnajdzPierwtze(int do_)
    {
        if (do_ < 2) return new List<int>();
        return Enumerable.Range(2, do_ - 1)
            .Where(CzyPierwsza)
            .ToList();
    }
}

public class Program
{
    static void Main()
    {
        Console.WriteLine("Liczby pierwsze do 50:");
        var pierwsze = MatematykaPierwsza.ZnajdzPierwtze(50);
        Console.WriteLine(string.Join(", ", pierwsze));
    }
}
