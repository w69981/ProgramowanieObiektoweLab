using System;
using System.Collections.Generic;

namespace Lab05_w69981
{
    internal class KlasaB : KlasaA
    {
        public KlasaB(int liczba1, int liczba2) : base(liczba1, liczba2)
        {
        }

        public override void WirtualnaA()
        {
            Console.WriteLine("Nadpisana wirtualna metoda w klasie B:");
            Console.WriteLine($"Różnica Liczba1 - Liczba2 = {Liczba1 - Liczba2}");
        }

        public new void NormalnaA()
        {
            Console.WriteLine("Metoda niewirtualna z klasy B");
        }
    }
}