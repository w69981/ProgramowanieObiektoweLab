using Lab03;
using System;

namespace Lab03
{
    internal class SamochodOsobowy : Samochod
    {
        private double waga, pojemnoscSilnika;
        private int iloscOsob;

        public double Waga
        {
            get => waga;
            set
            {
                if (value >= 2 && value <= 4.5)
                    waga = value;
                else
                    throw new ArgumentException("Waga musi być w zakresie 2-4.5 tony");
            }
        }

        public double PojemnoscSilnika
        {
            get => pojemnoscSilnika;
            set
            {
                if (value >= 0.8 && value <= 3.0)
                    pojemnoscSilnika = value;
                else
                    throw new ArgumentException("Pojemność silnika musi być w zakresie 0.8-3.0 litra");
            }
        }

        public int IloscOsob
        {
            get => iloscOsob;
            set
            {
                if (value > 0)
                    iloscOsob = value;
                else
                    throw new ArgumentException("Ilość osób musi być większa od zera");
            }
        }

        public SamochodOsobowy() : base()
        {
            Console.WriteLine("Podaj wagę pojazdu: ");
            Waga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj pojemność silnika: ");
            PojemnoscSilnika = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj ilość miejsc w pojeździe: ");
            IloscOsob = Convert.ToInt32(Console.ReadLine());
        }

        public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, int rokProdukcji, double przebieg, double waga, double pojemnoscSilnika, int iloscOsob)
            : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
        {
            Waga = waga;
            PojemnoscSilnika = pojemnoscSilnika;
            IloscOsob = iloscOsob;
        }

        public override string View()
        {
            return base.View() + ($" - Waga:\t{Waga} t\n - Pojemność Silnika:\t{PojemnoscSilnika} L\n - Ilość Osób:\t{IloscOsob}\n");
        }
    }
}
