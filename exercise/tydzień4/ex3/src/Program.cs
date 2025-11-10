using System;
using System.Collections.Generic;
using School.Core;
using System.Linq;

Console.WriteLine("--- Demonstracja dziedziczenia ---");

var osoba1 = new Person("Anna", "Nowak", new DateTime(1985, 10, 20));
var student1 = new Student("Tomasz", "Kot", new DateTime(2002, 3, 15), "S54321", "Architektura");
var osoba2 = new Person("Marek", "Wiśniewski", new DateTime(1970, 5, 5));
var student2 = new Student("Zofia", "Bąk", new DateTime(2003, 11, 1), "S67890", "Medycyna");

List<Person> listaOsob = new List<Person>();
listaOsob.Add(osoba1);
listaOsob.Add(student1);
listaOsob.Add(osoba2);
listaOsob.Add(student2);

Console.WriteLine("\n--- Lista oryginalna (kolejność dodawania) ---");
foreach (Person osoba in listaOsob)
{
    Console.WriteLine(osoba.GetDescription());
}

var posortowanaLista = listaOsob.OrderBy(osoba => osoba.LastName).ToList();

Console.WriteLine("\n--- Lista posortowana po nazwisku ---");
foreach (Person osoba in posortowanaLista)
{
    Console.WriteLine(osoba.GetDescription());
}

Console.WriteLine("\n--- Lista oryginalna (bez zmian) ---");
foreach (Person osoba in listaOsob)
{
    Console.WriteLine(osoba.GetDescription());
}

Console.WriteLine("\n--- Metoda specyficzna dla Studenta ---");
student1.ChangeMajor("Inżynieria Lądowa");
Console.WriteLine($"Nowy kierunek studenta {student1.GetFullName()}: {student1.Major}");

namespace School.Core
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) 
                    age--;
                return age;
            }
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Imie nie moze być puste.", nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Nazwsisko nie moze być puste.", nameof(lastName));
            if (dateOfBirth > DateTime.Now)
                throw new ArgumentOutOfRangeException(nameof(dateOfBirth), "Data urodzenia nie moze byc w przyszlosci.");

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public virtual string GetDescription()
        {
            return $"Imię: {GetFullName()}, Wiek: {Age}";
        }
    }

    public class Student : Person
    {
        public string StudentId { get; }
        public string Major { get; private set; }

        public Student(
            string firstName, 
            string lastName, 
            DateTime dateOfBirth, 
            string studentId, 
            string major)
            : base(firstName, lastName, dateOfBirth) 
        {
            if (string.IsNullOrWhiteSpace(studentId))
                throw new ArgumentException("Id studenta nie moze byc puste.", nameof(studentId));
            if (string.IsNullOrWhiteSpace(major))
                throw new ArgumentException("Kierunek nie moze byc pusty.", nameof(major));

            StudentId = studentId;
            Major = major;
        }

        public void ChangeMajor(string newMajor)
        {
            if (string.IsNullOrWhiteSpace(newMajor))
                throw new ArgumentException("Nowy kierunek nie moze byc pusty.", nameof(newMajor));
            
            Major = newMajor;
        }

        public override string GetDescription()
        {
            return $"Student: {GetFullName()} (ID: {StudentId}), Kierunek: {Major}, Wiek: {Age}";
        }
    }
}