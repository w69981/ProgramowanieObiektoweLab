using System;
using System.Collections.Generic;
using Lab05_w69981;

//class Program
//{
//    static void Main(string[] args)
//    {
//       
//        KlasaA a1 = new KlasaA(5, 10);
//        KlasaA a2 = new KlasaA(15, 20);
//        KlasaB b1 = new KlasaB(25, 5);
//        KlasaB b2 = new KlasaB(30, 10);
//        KlasaC c1 = new KlasaC(2, 3);
//        KlasaC c2 = new KlasaC(4, 5);

//     
//        List <KlasaA> listaA = new List<KlasaA> { a1, a2, b1, c1 };
//        List < KlasaB> listaB= new List<KlasaB> { b1, b2, c1 };
//        List < KlasaC > listaC= new List<KlasaC> { c1, c2 };

//        
//        Console.WriteLine("Lista A:");
//        foreach (KlasaA item in listaA)
//        {
//            item.WirtualnaA();
//            item.NormalnaA();
//            Console.WriteLine();
//        }


//        Console.WriteLine("\nLista B:");
//        foreach (KlasaB item in listaB)
//        {
//            item.WirtualnaA();
//            item.NormalnaA();
//            Console.WriteLine();
//        }


//        Console.WriteLine("\nLista C:");
//        foreach (KlasaC item in listaC)
//        {
//            item.WirtualnaA();
//            item.NormalnaA();
//            Console.WriteLine();
//        }
//    }
//}

//1a) Do listy A można wszystkie czyli A B oraz C, do listy B tylko B lub C, a do listy C tylko C

//1b WirtulnaA wywoływana jest zgodnie z rzeczywistym typem obiektu, czyli polimorficznie
//a metoda niewirtulna czyli NormalnaA wywoływana jest zgodnie z typem listy czyli statycznie

//1c Dodanie base.WirtualnaA() w C powoduje, że przed wynikiem z C wyświetlany jest wynik metody WirtualnaA z klasy B, co łączy działania obu klas

//zad2 


class Program
{
    static void Main()
    {



        //Test klasy Punkt
        Console.WriteLine("=== Testy Punktu ===");

        Punkt punkt1 = new Punkt(0, 0);
        Punkt punkt2 = new Punkt(3, 4);
        Console.WriteLine("Punkt 1: " + punkt1);
        Console.WriteLine("Punkt 2: " + punkt2);

        //Obliczanie odległości między punktami
        Console.WriteLine("Odległość między Punkt 1 a Punkt 2: " + punkt1.Distance(punkt2));

        //Przesunięcie Punktu 1 o (2, 2)
        punkt1.Move(2, 2);
        Console.WriteLine("Po przesunięciu Punktu 1 o (2, 2): " + punkt1);

        //Klonowanie Punktu 1
        Punkt punkt1Clone = punkt1.Clone();
        Console.WriteLine("Klon Punktu 1: " + punkt1Clone);

        //Sprawdzenie równości punktów
        Console.WriteLine("Czy Punkt 1 jest równy jego klonowi? " + punkt1.Equals(punkt1Clone));
        Console.WriteLine("Czy Punkt 1 jest równy Punkt 2? " + punkt1.Equals(punkt2));








        //Test klasy Trojkat
        Console.WriteLine("\n=== Testy Trójkąta ===");

        Punkt a = new Punkt(0, 0);
        Punkt b = new Punkt(3, 0);
        Punkt c = new Punkt(3, 4);
        Trojkat trojkat = new Trojkat(a, b, c, "Trójkąt ABC");
        Console.WriteLine(" " + trojkat);

        //Obliczanie obwodu trójkąta
        Console.WriteLine("Obwód Trójkąta ABC: " + trojkat.GetCrc());

        //Przesunięcie trójkąta o (1, 1)
        trojkat.Move(1, 1);
        Console.WriteLine("Po przesunięciu Trójkąta ABC o (1, 1): " + trojkat);

        //Klonowanie trójkąta
        Trojkat trojkatClone = trojkat.Clone();
        Console.WriteLine("Klon Trójkąta ABC: " + trojkatClone);

        //Sprawdzenie równości trójkąta i jego klonu
        Console.WriteLine("Czy Trójkąt ABC jest równy swojemu klonowi? " + trojkat.Equals(trojkatClone));








        Console.WriteLine();
      
        //Test klasy Kolo 
        Console.WriteLine("=== Testy Koła ===");

        //Tworzenie koła z punktem środkowym (5, 5) i promieniem 3
        Kolo kolo1 = new Kolo(5, 5, 3, "Koło 1");
        Console.WriteLine("Koło 1: " + kolo1);

        //Obliczanie obwodu koła
        Console.WriteLine("Obwód Koła 1: " + kolo1.GetCrc());

        //Przesunięcie Koła 1 o (2, 3)
        kolo1.Move(2, 3);
        Console.WriteLine("Po przesunięciu Koła 1 o (2, 3): " + kolo1);

        //Klonowanie Koła 1
        Kolo kolo1Clone = kolo1.Clone();
        Console.WriteLine("Klon Koła 1: " + kolo1Clone);

        //Sprawdzenie równości Koła 1 i jego klonu
        Console.WriteLine("Czy Koło 1 jest równy swojemu klonowi? " + kolo1.Equals(kolo1Clone));

        //Tworzenie drugiego koła z innym środkiem i promieniem
        Kolo kolo2 = new Kolo(10, 10, 5, "Koło 2");
        Console.WriteLine("\nKoło 2: " + kolo2);

        //Obliczanie obwodu Koła 2
        Console.WriteLine("Obwód Koła 2: " + kolo2.GetCrc());

        //Porównanie obwodów kół
        Console.WriteLine("Czy obwód Koła 1 < obwód Koła 2? " + (kolo1.GetCrc() < kolo2.GetCrc()));

        //Sprawdzenie równości Koła 1 i Koła 2
        Console.WriteLine("Czy Koło 1 jest równy Kołu 2? " + kolo1.Equals(kolo2));










        Console.WriteLine();
        //Test klasy wielobok 
        Console.WriteLine("=== Testy Wieloboku ===");

        // Tworzenie wierzchołków wieloboku (prostokąta)
        List<Punkt> vertices = new List<Punkt>
        {
            new Punkt(0, 0),
            new Punkt(4, 0),
            new Punkt(4, 3),
            new Punkt(0, 3)
        };

        // Tworzenie wieloboku Prostokąt ABCD
        Wielobok prostokat = new Wielobok(vertices, "Prostokąt ABCD");
        Console.WriteLine("Prostokąt ABCD: " + prostokat);

        // Wyświetlanie wszystkich wierzchołków prostokąta
        Console.WriteLine("Wierzchołki Prostokąta ABCD:");
        foreach (Punkt vertex in prostokat.Vertices)
        {
            Console.WriteLine(vertex);
        }

        // Obliczanie obwodu prostokąta
        Console.WriteLine("Obwód Prostokąta ABCD: " + prostokat.GetCrc());

        // Przesunięcie prostokąta o (2, 2)
        prostokat.Move(2, 2);
        Console.WriteLine("\nPo przesunięciu Prostokąta ABCD o (2, 2): " + prostokat);

        // Wyświetlanie wszystkich wierzchołków prostokąta po przesunięciu
        Console.WriteLine("Wierzchołki Prostokąta ABCD po przesunięciu:");
        foreach (Punkt vertex in prostokat.Vertices)
        {
            Console.WriteLine(vertex);
        }

        // Klonowanie prostokąta
        Wielobok prostokatClone = prostokat.Clone();
        Console.WriteLine("\nKlon Prostokąta ABCD: " + prostokatClone);

        // Wyświetlanie wierzchołków klonu
        Console.WriteLine("Wierzchołki Klonu Prostokąta ABCD:");
        foreach (Punkt vertex in prostokatClone.Vertices)
        {
            Console.WriteLine(vertex);
        }

        // Sprawdzenie równości prostokąta i jego klonu
        Console.WriteLine("Czy Prostokąt ABCD jest równy swojemu klonowi? " + prostokat.Equals(prostokatClone));

        // Dodawanie nowego wierzchołka do prostokąta
        prostokat.AddVertex(new Punkt(2, 7));
        Console.WriteLine("\nPo dodaniu nowego wierzchołka do Prostokąta ABCD: " + prostokat);

        // Wyświetlanie wierzchołków prostokąta po dodaniu nowego punktu
        Console.WriteLine("Wierzchołki figury ABCDE po dodaniu nowego punktu:");
        foreach (Punkt vertex in prostokat.Vertices)
        {
            Console.WriteLine(vertex);
        }

        // Nowy obwód po dodaniu punktu
        Console.WriteLine("Nowy obwód figury ABCDE: " + prostokat.GetCrc());
    
}
}
