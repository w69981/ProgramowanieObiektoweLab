//using System;
//using System.Collections.Generic;

////zad1

//namespace Lab0
//{
//    enum Operacja
//    {
//        Dodawanie,
//        Odejmowanie,
//        Mnożenie,
//        Dzielenie
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<double> wyniki = new List<double>();

//            while (true)
//            {
//                try
//                {
//                    Console.WriteLine("Podaj pierwszą liczbę:");
//                    double liczba1 = double.Parse(Console.ReadLine());

//                    Console.WriteLine("Podaj drugą liczbę:");
//                    double liczba2 = double.Parse(Console.ReadLine());

//                    Console.WriteLine("Wybierz operację: 0 - Dodawanie, 1 - Odejmowanie, 2 - Mnożenie, 3 - Dzielenie");
//                    Operacja operacja = (Operacja)Enum.Parse(typeof(Operacja), Console.ReadLine());

//                    double wynik = WykonajOperacje(liczba1, liczba2, operacja);
//                    Console.WriteLine($"Wynik: {wynik}");
//                    wyniki.Add(wynik);
//                }
//                catch (DivideByZeroException)
//                {
//                    Console.WriteLine("Błąd dzielenia przez zero");
//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine("Błąd, nieprawidłowe dane");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Nieoczekiwany błąd: {ex.Message}");
//                }

//                Console.WriteLine("\nHistoria obliczeń:");
//                foreach (var wynik in wyniki)
//                {
//                    Console.WriteLine(wynik);
//                }

//                Console.WriteLine("\nCzy chcesz kontynuować? (t/n):");
//                if (Console.ReadLine().ToLower() != "t") break;
//            }
//        }

//        static double WykonajOperacje(double liczba1, double liczba2, Operacja operacja)
//        {
//            return operacja switch
//            {
//                Operacja.Dodawanie => liczba1 + liczba2,
//                Operacja.Odejmowanie => liczba1 - liczba2,
//                Operacja.Mnożenie => liczba1 * liczba2,
//                Operacja.Dzielenie => (double)((decimal)liczba1 / (decimal)liczba2),
//                _ => throw new InvalidOperationException("Nieprawidłowa operacja")
//            };
//        }
//    }
////}





////zad2
//using System;
//using System.Collections.Generic;

//namespace Lab06
//{
//    enum StatusZamowienia
//    {
//        Oczekujące,
//        Przyjęte,
//        Zrealizowane,
//        Anulowane
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Dictionary przechowująca zamówienia: numer zamówienia => (status, lista produktów)
//            Dictionary<int, (StatusZamowienia status, List<string> produkty)> zamowienia = new();

//            while (true)
//            {
//                try
//                {
//                    Console.WriteLine("\n1 - Dodaj zamówienie\n2 - Zmień status\n3 - Wyświetl zamówienia\n4 - Wyjście");
//                    int wybor = int.Parse(Console.ReadLine());

//                    switch (wybor)
//                    {
//                        case 1:
//                            DodajZamowienie(zamowienia);
//                            break;
//                        case 2:
//                            ZmienStatus(zamowienia);
//                            break;
//                        case 3:
//                            WyswietlZamowienia(zamowienia);
//                            break;
//                        case 4:
//                            return;
//                        default:
//                            Console.WriteLine("Nieprawidłowy wybór. Sprobuj ponownie");
//                            break;
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Błąd: {ex.Message}");
//                }
//            }
//        }

//        static void DodajZamowienie(Dictionary<int, (StatusZamowienia status, List<string> produkty)> zamowienia)
//        {
//            Console.WriteLine("Podaj numer zamówienia:");
//            int numer = int.Parse(Console.ReadLine());

//            if (zamowienia.ContainsKey(numer))
//            {
//                Console.WriteLine("Zamówienie o tym numerze już istnieje");
//                return;
//            }

//            Console.WriteLine("Podaj produkty(oddzielone przecinkiem):");
//            List<string> produkty = new(Console.ReadLine().Split(','));

//            zamowienia[numer] = (StatusZamowienia.Oczekujące, produkty);
//            Console.WriteLine("Zamówienie zostało dodane");
//        }

//        static void ZmienStatus(Dictionary<int, (StatusZamowienia status, List<string> produkty)> zamowienia)
//        {
//            Console.WriteLine("Podaj numer zamówienia:");
//            int numer = int.Parse(Console.ReadLine());

//            if (!zamowienia.TryGetValue(numer, out var zamowienie))
//            {
//                Console.WriteLine("Zamówienie o podanym numerze nie istnieje");
//                return;
//            }

//            Console.WriteLine("Podaj nowy status(0 - Oczekujące, 1 - Przyjęte, 2 - Zrealizowane, 3 - Anulowane):");
//            StatusZamowienia nowyStatus = (StatusZamowienia)int.Parse(Console.ReadLine());

//            if (zamowienie.status == nowyStatus)
//            {
//                Console.WriteLine("Nowy status jest taki sam jak obecny");
//                return;
//            }

//            zamowienia[numer] = (nowyStatus, zamowienie.produkty);
//            Console.WriteLine("Status zamówienia został zmieniony");
//        }

//        static void WyswietlZamowienia(Dictionary<int, (StatusZamowienia status, List<string> produkty)> zamowienia)
//        {
//            if (zamowienia.Count == 0)
//            {
//                Console.WriteLine("Brak zamówień w systemie");
//                return;
//            }

//            foreach (var zamowienie in zamowienia)
//            {
//                Console.WriteLine($"\nZamówienie {zamowienie.Key}:");
//                Console.WriteLine($"  Status: {zamowienie.Value.status}");
//                Console.WriteLine($"  Produkty: {string.Join(", ", zamowienie.Value.produkty)}");
//            }
//        }
//    }
//}




//zad3
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab06
{
    enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        Żółty,
        Fioletowy
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Kolor> kolory = Enum.GetValues(typeof(Kolor)).Cast<Kolor>().ToList();
            Random rand = new Random();
            Kolor wylosowanyKolor = kolory[rand.Next(kolory.Count)];

            Console.WriteLine("Zgadnij wylosowany kolor (Czerwony, Niebieski, Zielony, Żółty, Fioletowy):");
            while (true)
            {
                try
                {
                    Kolor zgadniecie = (Kolor)Enum.Parse(typeof(Kolor), Console.ReadLine(), true);

                    if (zgadniecie == wylosowanyKolor)
                    {
                        Console.WriteLine("Gratulacje! Zgadłeś!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Zła odpowiedź. Spróbuj ponownie.");
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Nieprawidłowy kolor. Spróbuj ponownie.");
                }
            }
        }
    }
}
