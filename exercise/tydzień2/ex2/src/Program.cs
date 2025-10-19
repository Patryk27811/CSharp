using System;
using System.Linq;

namespace TablicaSrednia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] liczby = new int[10];

            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out liczby[i]))
                {
                    Console.Write("Błędna wartość, podaj liczbę całkowitą: ");
                }
            }

            double srednia = ObliczSrednia(liczby);
            Console.WriteLine($"Średnia wynosi: {srednia}");
        }

        public static double ObliczSrednia(int[] liczby)
        {
            if (liczby == null || liczby.Length == 0)
                throw new ArgumentException("Tablica nie może być pusta.");

            return liczby.Average();
        }
    }
}
