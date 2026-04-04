public static class Stoper
{
    public static async Task<TimeSpan> ZmierzCzasAsync(Func<Task> operacja)
    {
        if (operacja == null)
            throw new ArgumentNullException(nameof(operacja));

        var start = DateTime.UtcNow;
        await operacja();
        return DateTime.UtcNow - start;
    }
}

public class Program
{
    static async Task Main()
    {
        var czas = await Stoper.ZmierzCzasAsync(async () =>
        {
            Console.WriteLine("Rozpoczynam operację...");
            await Task.Delay(200);
            Console.WriteLine("Zakończono operację.");
        });

        Console.WriteLine($"Czas wykonania: {czas.TotalMilliseconds:F0} ms");
    }
}
