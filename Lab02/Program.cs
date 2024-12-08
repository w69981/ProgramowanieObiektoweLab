//// =======================Main===========================

using Lab02;

//Samochod samochod = new Samochod();

//samochod.marka = "Toyota";
//samochod.model = "Corolla";
//samochod.View();

//samochod.rokProdukcji = 125;


//try
//{
//    Osoba osoba = new("jan", "nowak", 12);
//    osoba.View();

//}


//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}



//int[] numery = new int[2] { 1, 2 };

//Osoba[] osoby = new Osoba[]
//{
//    new Osoba("jan", "nowak", 12),
//    new Osoba("jan", "nowak", 12)
//};


//--------------------------------------------

//zad2

//try
//{
//    BankAccount konto = new BankAccount("Jan Kowalski", 1000);
//    konto.Wplata(500);
//    konto.Wyplata(200);
//    Console.WriteLine($"Saldo: {konto.Saldo}");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}



//--------------------------------------------

//zad3

//try
//{
//    Student student = new Student("Anna", "Nowak");
//    student.DodajOcene(5);
//    student.DodajOcene(3);
//    student.DodajOcene(6);
//    student.View();
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}



//--------------------------------------------

//zad4


//Licz liczba = new Licz(10);
//liczba.Dodaj(5);
//liczba.Odejmij(3);
//liczba.View();


//--------------------------------------------

//zad5
int[] liczby = { 1, 2, 3, 4, 5, 6 };
Sumator sumator = new Sumator(liczby);
Console.WriteLine($"Suma: {sumator.Suma()}");
Console.WriteLine($"Suma liczb podzielnych przez 2: {sumator.SumaPodziel2()}");
Console.WriteLine($"Liczba elementów: {sumator.IleElementow()}");
sumator.View();
sumator.ViewZakres(1, 4);
