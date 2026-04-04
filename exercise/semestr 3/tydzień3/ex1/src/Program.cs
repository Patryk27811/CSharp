using System;
using System.Collections.Generic;

public class RandomNumbers
{
    public static void Main(string[] args)
    {
        
        Random random = new Random();

        
        List<int> randomNumbers = new List<int>();

        
        for (int i = 0; i < 100; i++)
        {
            
            int randomNumber = random.Next(0, 100001);
            randomNumbers.Add(randomNumber);
        }

       
        Console.WriteLine("Wygenerowano 100 liczb losowych:");
        foreach (int number in randomNumbers)
        {
            Console.Write(number + " ");
        }

        
        int maxValue = int.MinValue;
        foreach (int number in randomNumbers)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }

        
        Console.WriteLine("\n\nNajwiększa wartość w ciągu to: " + maxValue);
    }
}
