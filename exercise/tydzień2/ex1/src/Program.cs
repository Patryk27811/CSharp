using System;

namespace SilniaRekurencyjna
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Podaj liczbę n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                long wynik = ObliczSilnie(n);
                Console.WriteLine($"Silnia z {n} wynosi: {wynik}");
            }
            else
            {
                Console.WriteLine("Błędna wartość! Podaj liczbę całkowitą.");
            }
        }

        public static long ObliczSilnie(int n)
        {
            if (n < 0)
                throw new ArgumentException("Silnia nie jest zdefiniowana dla liczb ujemnych.");

            if (n == 0 || n == 1)
                return 1;

            return n * ObliczSilnie(n - 1);
        }
    }
}
