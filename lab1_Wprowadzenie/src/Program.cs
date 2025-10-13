using System.CommandLine;

namespace LabApp;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        Console.WriteLine("== Lab01 Wprowadzenie ==");

        var aArg = new Argument<int>("a", "Pierwsza liczba");
        var bArg = new Argument<int>("b", "Druga liczba");
        var add = new Command("add", "Dodaj dwie liczby") { aArg, bArg };
        add.SetHandler((int a, int b) => Console.WriteLine(Calculator.Add(a, b)), aArg, bArg);

        var sub = new Command("sub", "Odejmij dwie liczby") { aArg, bArg };
        sub.SetHandler((int a, int b) => Console.WriteLine(Calculator.Sub(a, b)), aArg, bArg);

        var calc = new Command("calc", "Prosty kalkulator");
        calc.AddCommand(add);
        calc.AddCommand(sub);

        var root = new RootCommand("Lab01 demo CLI");
        root.AddCommand(calc);

        return await root.InvokeAsync(args);
    }
}

public static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Sub(int a, int b) => a - b;
}

