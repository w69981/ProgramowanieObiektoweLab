using System;

namespace Lab03
{
    internal class Samochod
    {
        private string marka, model, nadwozie, kolor;
        private int rokProdukcji;
        private double przebieg;

        public string Marka
        {
            get => marka;
            set => marka = value ?? throw new ArgumentNullException("Marka nie może być pusta");
        }

        public string Model
        {
            get => model;
            set => model = value ?? throw new ArgumentNullException("Model nie może być pusty");
        }

        public string Nadwozie
        {
            get => nadwozie;
            set => nadwozie = value ?? throw new ArgumentNullException("Nadwozie nie może być puste");
        }

        public string Kolor
        {
            get => kolor;
            set => kolor = value ?? throw new ArgumentNullException("Kolor nie może być pusty");
        }

        public int RokProdukcji
        {
            get => rokProdukcji;
            set
            {
                if (value > 1885) // Pierwszy samochód spalinowy wyprodukowano w 1886
                    rokProdukcji = value;
                else
                    throw new ArgumentException("Nieprawidłowy rok produkcji");
            }
        }

        public double Przebieg
        {
            get => przebieg;
            set
            {
                if (value >= 0)
                    przebieg = value;
                else
                    throw new ArgumentException("Przebieg nie może być ujemny");
            }
        }

        public Samochod()
        {
            Console.WriteLine("Podaj markę pojazdu: ");
            Marka = Console.ReadLine();
            Console.WriteLine("Podaj model pojazdu: ");
            Model = Console.ReadLine();
            Console.WriteLine("Podaj rodzaj nadwozia pojazdu: ");
            Nadwozie = Console.ReadLine();
            Console.WriteLine("Podaj kolor pojazdu: ");
            Kolor = Console.ReadLine();
            Console.WriteLine("Podaj rok produkcji pojazdu: ");
            RokProdukcji = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj przebieg pojazdu: ");
            Przebieg = Convert.ToDouble(Console.ReadLine());
        }

        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, double przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }

        public virtual string View()
        {
            return ($"\n - Marka:\t{Marka}\n - Model:\t{Model}\n - Nadwozie:\t{Nadwozie}\n - Kolor:\t{Kolor}\n - Rok Produkcji:\t{RokProdukcji}\n - Przebieg:\t{Przebieg} km\n");
        }
    }
}
