//////zad1
//////using System;
//////using System.Collections.Generic;

//////namespace Lab04
//////{
//////    class Shape
//////    {
//////        public int X { get; set; }
//////        public int Y { get; set; }
//////        public int Height { get; set; }
//////        public int Width { get; set; }

//////        public virtual void Draw()
//////        {
//////            Console.WriteLine("Drawing a generic shape.");
//////        }
//////    }

//////    class Rectangle : Shape
//////    {
//////        public override void Draw()
//////        {
//////            Console.WriteLine("Drawing a rectangle.");
//////        }
//////    }

//////    class Triangle : Shape
//////    {
//////        public override void Draw()
//////        {
//////            Console.WriteLine("Drawing a triangle.");
//////        }
//////    }

//////    class Circle : Shape
//////    {
//////        public override void Draw()
//////        {
//////            Console.WriteLine("Drawing a circle.");
//////        }
//////    }

//////    class Program
//////    {
//////        static void Main(string[] args)
//////        {
//////            List<Shape> shapes = new List<Shape>
//////            {
//////                new Rectangle(),
//////                new Triangle(),
//////                new Circle()
//////            };

//////            foreach (var shape in shapes)
//////            {
//////                shape.Draw();
//////            }
//////        }
//////    }
//////}




//////zad2
////using System;
////using System.Collections.Generic;

////namespace Lab04
////{
////    class Osoba
////    {
////        public string Imie { get; set; }
////        public string Nazwisko { get; set; }
////        public string Pesel { get; set; }

////        public virtual int GetAge()
////        {
////            DateTime birthDate = PeselToDate(Pesel);
////            return DateTime.Now.Year - birthDate.Year;
////        }

////        public virtual string GetGender()
////        {
////            return (int.Parse(Pesel[9].ToString()) % 2 == 0) ? "Female" : "Male";
////        }

////        protected DateTime PeselToDate(string pesel)
////        {
////            int year = int.Parse(pesel.Substring(0, 2));
////            int month = int.Parse(pesel.Substring(2, 2));
////            int day = int.Parse(pesel.Substring(4, 2));

////            if (month > 20)
////            {
////                year += 2000;
////                month -= 20;
////            }
////            else
////            {
////                year += 1900;
////            }

////            return new DateTime(year, month, day);
////        }

////        public virtual string GetEducationInfo()
////        {
////            return "No education information available.";
////        }

////        public virtual string GetFullName()
////        {
////            return $"{Imie} {Nazwisko}";
////        }

////        public virtual bool CanGoAloneToHome()
////        {
////            return GetAge() >= 18;
////        }
////    }

////    class Uczen : Osoba
////    {
////        public string Szkola { get; set; }
////        public bool MozeSamWracacDoDomu { get; set; }

////        public override string GetEducationInfo()
////        {
////            return $"School: {Szkola}";
////        }

////        public override bool CanGoAloneToHome()
////        {
////            return GetAge() >= 12 || MozeSamWracacDoDomu;
////        }
////    }

////    class Nauczyciel : Uczen
////    {
////        public string TytulNaukowy { get; set; }
////        public List<Uczen> PodwladniUczniowie { get; set; } = new List<Uczen>();

////        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
////        {
////            Console.WriteLine("Students who can go home alone:");
////            foreach (var uczen in PodwladniUczniowie)
////            {
////                if (uczen.CanGoAloneToHome())
////                {
////                    Console.WriteLine(uczen.GetFullName());
////                }
////            }
////        }
////    }

////    class Program
////    {
////        static void Main(string[] args)
////        {
////            var student1 = new Uczen { Imie = "Jan", Nazwisko = "Kowalski", Pesel = "03210112345", Szkola = "SP1", MozeSamWracacDoDomu = true };
////            var student2 = new Uczen { Imie = "Anna", Nazwisko = "Nowak", Pesel = "08220156789", Szkola = "SP1", MozeSamWracacDoDomu = false };

////            var teacher = new Nauczyciel { Imie = "Maria", Nazwisko = "Zielinska", TytulNaukowy = "Dr." };
////            teacher.PodwladniUczniowie.Add(student1);
////            teacher.PodwladniUczniowie.Add(student2);

////            teacher.WhichStudentCanGoHomeAlone(DateTime.Now);
////        }
////    }
////}


//////zad3

//////3a
////using Lab04;
////using System;
////using System.Collections.Generic;

////namespace Lab04
////{
////    interface IOsoba
////    {
////        string Imie { get; set; }
////        string Nazwisko { get; set; }

////        string ZwrocPelnaNazwe();
////    }

////    class Osoba : IOsoba
////    {
////        public string Imie { get; set; }
////        public string Nazwisko { get; set; }

////        public string ZwrocPelnaNazwe()
////        {
////            return $"{Imie} {Nazwisko}";
////        }
////    }

////    class Program
////    {
////        static void Main(string[] args)
////        {
////            List<IOsoba> osoby = new List<IOsoba>
////            {
////                new Osoba { Imie = "Jan", Nazwisko = "Kowalski" },
////                new Osoba { Imie = "Anna", Nazwisko = "Nowak" },
////                new Osoba { Imie = "Tomasz", Nazwisko = "Zieliński" }
////            };

////            foreach (var osoba in osoby)
////            {
////                Console.WriteLine(osoba.ZwrocPelnaNazwe());
////            }
////        }
////    }
////}

//////3b
//////static class Extensions
//////{
//////    public static void WypiszOsoby(this List<IOsoba> osoby)
//////    {
//////        foreach (var osoba in osoby)
//////        {
//////            Console.WriteLine(osoba.ZwrocPelnaNazwe());
//////        }
//////    }
//////}


//////3c
////static class Extensions
////{
////    public static void PosortujOsobyPoNazwisku(this List<IOsoba> osoby)
////    {
////        osoby.Sort((a, b) => string.Compare(a.Nazwisko, b.Nazwisko));
////    }
////}


////3d
//using System;
//using System.Collections.Generic;

//namespace Lab03
//{
//    public interface IOsoba
//    {
//        string Imie { get; set; }
//        string Nazwisko { get; set; }
//        string ZwrocPelnaNazwe();
//    }

//    public interface IStudent : IOsoba
//    {
//        string Uczelnia { get; set; }
//        string Kierunek { get; set; }
//        int Rok { get; set; }
//        int Semestr { get; set; }
//    }

//    public class Osoba : IOsoba
//    {
//        public string Imie { get; set; }
//        public string Nazwisko { get; set; }

//        public Osoba(string imie, string nazwisko)
//        {
//            Imie = imie;
//            Nazwisko = nazwisko;
//        }

//        public string ZwrocPelnaNazwe()
//        {
//            return $"{Imie} {Nazwisko}";
//        }
//    }

//    public class Student : Osoba, IStudent
//    {
//        public string Uczelnia { get; set; }
//        public string Kierunek { get; set; }
//        public int Rok { get; set; }
//        public int Semestr { get; set; }

//        public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr)
//            : base(imie, nazwisko)
//        {
//            Uczelnia = uczelnia;
//            Kierunek = kierunek;
//            Rok = rok;
//            Semestr = semestr;
//        }

//        public string WypiszPelnaNazweIUczelnie()
//        {
//            return $"{ZwrocPelnaNazwe()} – {Kierunek} {Rok} {Uczelnia}, semestr: {Semestr}";
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Tworzymy listę studentów
//            List<IStudent> studenci = new List<IStudent>
//            {
//                new Student("Jan", "Kowalski", "WSIiZ", "Informatyka", 2020, 3),
//                new Student("Anna", "Nowak", "AGH", "Automatyka", 2019, 5),
//                new Student("Tomasz", "Wiśniewski", "UJ", "Prawo", 2021, 2)
//            };

//            Console.WriteLine("Lista studentów:");

//            // Iteracja po liście i wywołanie metody WypiszPelnaNazweIUczelnie
//            foreach (var student in studenci)
//            {
//                if (student is Student konkretStudent)
//                {
//                    Console.WriteLine(konkretStudent.WypiszPelnaNazweIUczelnie());
//                }
//            }
//        }
//    }
//}

//3e
using System;
using System.Collections.Generic;

namespace Lab03
{
    
    public interface IOsoba
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        string ZwrocPelnaNazwe();
    }

    
    public class Osoba : IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }
    }

   
    public interface IStudent : IOsoba
    {
        string Uczelnia { get; set; }
        string Kierunek { get; set; }
        int Rok { get; set; }
        int Semestr { get; set; }
        string WypiszPelnaNazweIUczelnie();
    }

    public class Student : Osoba, IStudent
    {
        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }

        public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr)
            : base(imie, nazwisko)
        {
            Uczelnia = uczelnia;
            Kierunek = kierunek;
            Rok = rok;
            Semestr = semestr;
        }

        public virtual string WypiszPelnaNazweIUczelnie()
        {
            return $"{ZwrocPelnaNazwe()} – {Kierunek} {Rok} {Uczelnia}, semestr: {Semestr}";
        }
    }

    
    public class StudentWSIiZ : Student
    {
        public string Specjalizacja { get; set; }

        public StudentWSIiZ(string imie, string nazwisko, string kierunek, int rok, int semestr, string specjalizacja)
            : base(imie, nazwisko, "WSIiZ", kierunek, rok, semestr)
        {
            Specjalizacja = specjalizacja;
        }

        public override string WypiszPelnaNazweIUczelnie()
        {
            return $"{base.WypiszPelnaNazweIUczelnie()} – Specjalizacja: {Specjalizacja}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<StudentWSIiZ> studenciWSIiZ = new List<StudentWSIiZ>
            {
                new StudentWSIiZ("Jan", "Kowalski", "Informatyka", 2020, 3, "Sztuczna inteligencja"),
                new StudentWSIiZ("Anna", "Nowak", "Informatyka", 2019, 5, "Cyberbezpieczeństwo"),
                new StudentWSIiZ("Tomasz", "Wiśniewski", "Zarządzanie", 2021, 2, "Zarządzanie projektami")
            };

            Console.WriteLine("Lista studentów WSIiZ:");

            foreach (var student in studenciWSIiZ)
            {
                Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
            }
        }
    }
}
