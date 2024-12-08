// See https://aka.ms/new-console-template for more information
using Lab03;
using System;

//zadanie 1
//class Program
//{
//    static void Main()
//    {
//        // Authors
//        Person author1 = new Person("George", "Orwell", 46);
//        Person author2 = new Person("J.R.R.", "Tolkien", 81);

//        // Books
//        Book book1 = new AdventureBook("1984", author1, 1949);
//        Book book2 = new DocumentaryBook("The Hobbit", author2, 1937);

//        // Readers and Reviewers
//        List<Book> booksRead1 = new List<Book> { book1 };
//        List<Book> booksRead2 = new List<Book> { book1, book2 };

//        Reader reader1 = new Reader("Alice", "Smith", 25, booksRead1);
//        Reviewer reviewer1 = new Reviewer("Bob", "Brown", 30, booksRead2);

//        // Display Readers
//        Console.WriteLine("=== Reader 1 ===");
//        Console.WriteLine(reader1.View());

//        // Display Reviewers
//        Console.WriteLine("\n=== Reviewer 1 ===");
//        Console.WriteLine(reviewer1.View());

//        // Display Books
//        Console.WriteLine("\n=== Books ===");
//        Console.WriteLine(book1.View());
//        Console.WriteLine(book2.View());
//    }
//}


//zadanie 2 
using System;
using System.Collections.Generic;
using Lab03;

using System;

class Program
{
    static void Main()
    {
        try
        {
            // Tworzenie obiektów
            Samochod s1 = new Samochod("Renault", "Clio", "Hatchback", "Szare", 2003, 278000);
            Samochod s2 = new Samochod("Opel", "Astra", "Sedan", "Czerwone", 2005, 164000);
            Samochod s3 = new SamochodOsobowy("Toyota", "Corolla", "Hatchback", "Grafitowe", 2012, 140000, 2.5, 1.8, 5);
            Samochod s4 = new SamochodOsobowy();

            // Wyświetlenie informacji o samochodach
            Console.WriteLine(s1.View());
            Console.WriteLine(s2.View());
            Console.WriteLine(s3.View());
            Console.WriteLine(s4.View());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
    }
}
