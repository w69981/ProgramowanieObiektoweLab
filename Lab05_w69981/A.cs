using System;
using System.Collections.Generic;

namespace Lab05_w69981
{
    internal class KlasaA
    {
        public int Liczba1 { get; set; }
        public int Liczba2 { get; set; }

        public KlasaA(int liczba1, int liczba2)
        {
            Liczba1 = liczba1;
            Liczba2 = liczba2;
        }

        public virtual void WirtualnaA()
        {
            Console.WriteLine("Wirtualna metoda w klasie A:");
            Console.WriteLine($"Suma Liczba1 + Liczba2 = {Liczba1 + Liczba2}");
        }

        public void NormalnaA()
        {
            Console.WriteLine("Metoda niewirtualna z klasy A");
        }
    }
}