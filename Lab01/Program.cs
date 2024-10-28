//zadanie1(); //wywolanie metody

//void zadanie1()
//{
//    double a = DoubleInput();
//    double b = DoubleInput();
//    double c = DoubleInput();
//    double x1, x2, delta;
//    if (a == 0) Console.WriteLine("To nie jest rownanie kwadratowe");
//    else
//    {
//        delta = (Math.Pow(b, 2) - 4 * a * c);
//        if (delta > a)
//        {
//            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
//            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
//            Console.WriteLine($"Mamy dwa roziwązania x1={x1}, x2={x2}");
//        }
//        else if (delta == 0)
//        {
//            x1 = -b / (2 * a);
//            Console.WriteLine($"Mamy jedno rozwiązanie x={x1}");

//        }
//        else Console.WriteLine("brak rozwiazania w zbiorze liczb rzeczywistych");
//    }
//}

//double DoubleInput()
//{
//    Console.WriteLine("Podaj Liczbe:");
//    double value = Convert.ToDouble(Console.ReadLine());
//    return value;
//}







//-------------------------------------------------------------------
//zadanie 2
//menu();
//static void menu()
//    {
//        while (true)
//        {
//        Console.WriteLine("-----------------Kalkulator----------------\n1. Suma\n2. Roznica\n2. Iloczyn" +
//        "\n4. Iloraz\n5. Programowanie\n6. Pierwiastkowanie\n7. Trygonometria\n8. Wyjscie");

//            Console.WriteLine("Wybierz opcję:");

//            int choice = Convert.ToInt32(Console.ReadLine());

//            switch (choice)
//            {
//                case 1: Total(); break;
//                case 2: Difference(); break;
//                case 3: ProductNumber(); break;
//                case 4: QuotientNumber(); break;
//                case 5: PotentiationNumber(); break;
//                case 6: SquareNumber(); break;
//                case 7: Trigonometry(); break;
//                case 8: Close(); break;
//                default:
//                    Console.WriteLine("Błędne dane, spróbuj jeszcze raz.");
//                    break;
//            }
//        }
//    }

//    static void Total()
//    {
//        Console.WriteLine("Podaj dwie liczby:");
//        int a = Convert.ToInt32(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Suma: {a + b}");
//    }

//    static void Difference()
//    {
//        Console.WriteLine("Podaj dwie liczby:");
//        int a = Convert.ToInt32(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Różnica: {a - b}");
//    }

//    static void ProductNumber()
//    {
//        Console.WriteLine("Podaj dwie liczby:");
//        int a = Convert.ToInt32(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Iloczyn: {a * b}");
//    }

//    static void QuotientNumber()
//    {
//        Console.WriteLine("Podaj dwie liczby:");
//        double a = Convert.ToDouble(Console.ReadLine());
//        double b = Convert.ToDouble(Console.ReadLine());
//        if (b != 0)
//        {
//            Console.WriteLine($"Iloraz: {a / b}");
//        }
//        else
//        {
//            Console.WriteLine("Dzielenie przez zero jest niedozwolone.");
//        }
//    }

//    static void PotentiationNumber()
//    {
//        Console.WriteLine("Podaj podstawę i wykładnik:");
//        double a = Convert.ToDouble(Console.ReadLine());
//        double b = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine($"Wynik potęgowania: {Math.Pow(a, b)}");
//    }

//    static void SquareNumber()
//    {
//        Console.WriteLine("Podaj liczbę:");
//        double a = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine($"Pierwiastek kwadratowy: {Math.Sqrt(a)}");
//    }

//    static void Trigonometry()
//    {
//        Console.WriteLine("Podaj kąt w radianach:");
//        double angle = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine($"Sinus: {Math.Sin(angle)}");
//        Console.WriteLine($"Cosinus: {Math.Cos(angle)}");
//        Console.WriteLine($"Tangens: {Math.Tan(angle)}");
//    }

//    static void Close()
//    {
//        Console.WriteLine("Koniec programu. Do zobaczenia!");
//        Environment.Exit(0);
//    }






//------------------------------------
//zadanie 3
//ArrayOperation();
//static void ArrayOperation()
//{
//    double[] liczby = new double[10];
//    for (int i = 0; i < 10; i++)
//    {
//        Console.Write($"Podaj liczbe {i + 1}: ");
//        liczby[i] = Convert.ToDouble(Console.ReadLine());
//    }

//    while (true)
//    {
//        Console.WriteLine("\nMenu:");
//        Console.WriteLine("1. Wyświetl od pierwszego do ostatniego indeksu");
//        Console.WriteLine("2. Wyświetl od ostatniego do pierwszego indeksu");
//        Console.WriteLine("3. Wyświetl nieparzyste indeksy");
//        Console.WriteLine("4. Wyświetl parzyste indeksy");
//        Console.WriteLine("5. Wyjście");

//        int wybor = Convert.ToInt32(Console.ReadLine());

//        if (wybor == 5) break;

//        switch (wybor)
//        {
//            case 1:
//                for (int i = 0; i < liczby.Length; i++)
//                    Console.Write(liczby[i] + " ");
//                break;
//            case 2:
//                for (int i = liczby.Length - 1; i >= 0; i--)
//                    Console.Write(liczby[i] + " ");
//                break;
//            case 3:
//                for (int i = 1; i < liczby.Length; i += 2)
//                    Console.Write(liczby[i] + " ");
//                break;
//            case 4:
//                for (int i = 0; i < liczby.Length; i += 2)
//                    Console.Write(liczby[i] + " ");
//                break;
//            default:
//                Console.WriteLine("Nieprawidłowy wybór.");
//                break;
//        }
//        Console.WriteLine();
//    }
//}






//----------------------------------
//zadanie 4
//ArrayMathOperation();
//static void ArrayMathOperation()
//{
//    double[] liczby = new double[10];
//    for (int i = 0; i < 10; i++)
//    {
//        Console.Write($"Podaj liczbe {i + 1}: ");
//        liczby[i] = Convert.ToDouble(Console.ReadLine());
//    }

//    double suma = 0;
//    double iloczyn = 1;
//    double min = liczby[0];
//    double max = liczby[0];

//    foreach (double liczba in liczby)
//    {
//        suma += liczba;

//        iloczyn *= liczba;

//        if (liczba < min) 
//            min = liczba;

//        if (liczba > max) 
//            max = liczba;
//    }

//    double srednia = suma / liczby.Length;

//    Console.WriteLine($"Suma: {suma}");
//    Console.WriteLine($"Iloczyn: {iloczyn}");
//    Console.WriteLine($"Średnia: {srednia}");
//    Console.WriteLine($"Min: {min}");
//    Console.WriteLine($"Max: {max}");
//}


//---------------------------
////Zadanie 5
//zadanie5();

//static void zadanie5()
//{
//    for (int i = 20; i>=0; i--)
//    {
//        if (i ==2 || i == 6  || i ==9 || i == 15 || i == 19)
//                continue;

//    Console.WriteLine(i +" ");
//    }
//}







//---------------------------
//Zadanie 6
//Zadanie6();
//static void Zadanie6()
//{
//    while (true)
//    {
//        Console.WriteLine("Podaj liczbę całkowitą: ");
//        int liczba = Convert.ToInt32(Console.ReadLine());

//        if (liczba < 0)
//        {
//            Console.WriteLine("Koniec programu.");
//            break;
//        }
//    }
//}


//Zadanie 7
Zadanie7();
static void Zadanie7()
{
    Console.WriteLine("Ile liczb chcesz wprowadzić?");
    int n = Convert.ToInt32(Console.ReadLine());

    double[] liczby = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Podaj liczbe {i + 1}: ");
        liczby[i] = Convert.ToDouble(Console.ReadLine());
    }

    // Sortowanie bąbelkowe
    for (int i = 0; i < liczby.Length - 1; i++)
    {
        for (int j = 0; j < liczby.Length - i - 1; j++)
        {
            if (liczby[j] > liczby[j + 1])
            {
                double temp = liczby[j];
                liczby[j] = liczby[j + 1];
                liczby[j + 1] = temp;
            }
        }
    }




    Console.WriteLine("Posortowane liczby:");
    for (int i = 0; i < liczby.Length; i++)
    {
        double liczba = liczby[i];
        Console.Write(liczba + " ");
    }
}