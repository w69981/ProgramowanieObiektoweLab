////zad1
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Podaj nazwę pliku: ");
//        string fileName = Console.ReadLine();

//        Console.Write("Podaj numer albumu: ");
//        string albumNumber = Console.ReadLine();

//        File.WriteAllText(fileName, albumNumber);
//        Console.WriteLine("Numer albumu zapisany do pliku.");
//    }
//}


////zad2
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Podaj nazwę pliku do odczytu: ");
//        string fileName = Console.ReadLine();

//        if (File.Exists(fileName))
//        {
//            string content = File.ReadAllText(fileName);
//            Console.WriteLine("Zawartość pliku:");
//            Console.WriteLine(content);
//        }
//        else
//        {
//            Console.WriteLine("Plik nie istnieje.");
//        }
//    }
//}


//zad3
//Jeśli dziewiąta cyfra jest parzysta (0, 2, 4, 6, 8), to PESEL jest żeński.
using System;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string fileName = "pesels.txt";

        if (File.Exists(fileName))
        {
            string[] pesels = File.ReadAllLines(fileName);
            int femaleCount = pesels.Count(pesel => pesel.Length == 11 && int.Parse(pesel.Substring(9, 1)) % 2 == 0);

            Console.WriteLine($"Liczba żeńskich PESELi: {femaleCount}");
        }
        else
        {
            Console.WriteLine("Plik pesels.txt nie istnieje.");
        }
    }
}


