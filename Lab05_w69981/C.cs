using System;
using System.Collections.Generic;

namespace Lab05_w69981
{
    internal class KlasaC : KlasaB
    {
        public KlasaC(int liczba1, int liczba2) : base(liczba1, liczba2)
        {
        }

        public override void WirtualnaA()
        {
            Console.WriteLine("Nadpisana wirtualna metoda w klasie C:");
            base.WirtualnaA(); 
            Console.WriteLine($"Iloczyn Liczba1 * Liczba2 = {Liczba1 * Liczba2}");
        }

        public new void NormalnaA()
        {
            Console.WriteLine("Metoda niewirtualna z klasy C");
        }
    }
}