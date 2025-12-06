using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("--- Grupa Studencka  ---");

GrupaStudencka grupa = new GrupaStudencka("Informatyka Rok I");

try
{
    grupa.DodajStudenta(new Student("Jan Kowalski", 4.5));
    grupa.DodajStudenta(new Student("Anna Nowak", 5.0));
    grupa.DodajStudenta(new Student("Piotr Wiśniewski", 3.0));
    grupa.DodajStudenta(new Student("Maria Zielińska", 4.0));

    Console.WriteLine($"Grupa: {grupa.NazwaGrupy}");
    
    foreach (var student in grupa.PobierzStudentow())
    {
        Console.WriteLine($"- {student.Imie}: {student.Ocena}");
    }

    double srednia = grupa.ObliczSrednia();
    Console.WriteLine($"\nŚrednia ocen grupy: {srednia:F2}");
}
catch (Exception ex)
{
    Console.WriteLine($"BŁĄD: {ex.Message}");
}

public class Student
{
    public string Imie { get; }
    public double Ocena { get; }

    public Student(string imie, double ocena)
    {
        if (string.IsNullOrWhiteSpace(imie))
        {
            throw new ArgumentException("Imię studenta nie może być puste.");
        }
        if (ocena < 2.0 || ocena > 6.0)
        {
            throw new ArgumentException("Ocena musi być w zakresie 2.0 - 6.0.");
        }

        Imie = imie;
        Ocena = ocena;
    }
}

public class GrupaStudencka
{
    public string NazwaGrupy { get; }
    private List<Student> _studenci = new List<Student>();

    public GrupaStudencka(string nazwaGrupy)
    {
        if (string.IsNullOrWhiteSpace(nazwaGrupy))
        {
            throw new ArgumentException("Nazwa grupy nie może być pusta.");
        }
        NazwaGrupy = nazwaGrupy;
    }

    public void DodajStudenta(Student student)
    {
        if (student == null)
        {
            throw new ArgumentNullException(nameof(student));
        }
        _studenci.Add(student);
    }

    public List<Student> PobierzStudentow()
    {
        return new List<Student>(_studenci);
    }

    public double ObliczSrednia()
    {
        if (_studenci.Count == 0)
        {
            return 0.0;
        }

        return _studenci.Average(s => s.Ocena);
    }
}