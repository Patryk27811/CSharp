using System;

namespace CzyPierwsza
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                bool wynik = IsPrime(n);
                if (wynik)
                    Console.WriteLine($"{n} jest liczbą pierwszą.");
                else
                    Console.WriteLine($"{n} nie jest liczbą pierwszą.");
            }
            else
            {
                Console.WriteLine("Błędna wartość. Podaj liczbę całkowitą.");
            }
        }

        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
