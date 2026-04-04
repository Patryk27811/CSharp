public interface IKsztalt
{
    string Nazwa { get; }
    double Pole();
    double Obwod();
}

public class Okrag : IKsztalt
{
    private readonly double _promien;
    public string Nazwa => "Okrąg";

    public Okrag(double promien)
    {
        if (promien <= 0) throw new ArgumentException("Promień musi być dodatni.");
        _promien = promien;
    }

    public double Pole() => Math.PI * _promien * _promien;
    public double Obwod() => 2 * Math.PI * _promien;
}

public class Prostokat : IKsztalt
{
    private readonly double _szerokosc, _wysokosc;
    public string Nazwa => "Prostokąt";

    public Prostokat(double szerokosc, double wysokosc)
    {
        if (szerokosc <= 0 || wysokosc <= 0)
            throw new ArgumentException("Wymiary muszą być dodatnie.");
        _szerokosc = szerokosc;
        _wysokosc = wysokosc;
    }

    public double Pole() => _szerokosc * _wysokosc;
    public double Obwod() => 2 * (_szerokosc + _wysokosc);
}

public static class KsztaltFactory
{
    public static IKsztalt Utworz(string typ, params double[] parametry)
    {
        return typ.ToLower() switch
        {
            "okrag" or "circle" => new Okrag(parametry[0]),
            "prostokat" or "rectangle" => new Prostokat(parametry[0], parametry[1]),
            _ => throw new ArgumentException($"Nieznany typ kształtu: {typ}")
        };
    }
}

public class Program
{
    static void Main()
    {
        var ksztalty = new[]
        {
            KsztaltFactory.Utworz("okrag", 5),
            KsztaltFactory.Utworz("prostokat", 4, 6)
        };

        foreach (var k in ksztalty)
            Console.WriteLine($"{k.Nazwa}: pole={k.Pole():F2}, obwód={k.Obwod():F2}");
    }
}
