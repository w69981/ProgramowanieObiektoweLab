using System;
using System.Collections.Generic;

namespace Lab05_w69981
{
    internal class Wielobok : ICloneable
    {
        private List<Punkt> vertices; //Lista wierzchołków wieloboku
        private string name;

        public List<Punkt> Vertices { get => vertices; set => vertices = value; }
        public string Name { get => name; set => name = value; }

        //Konstruktor domyślny
        public Wielobok(string name)
        {
            Vertices = new List<Punkt>();
            Name = name;
        }

        //Konstruktor z listą punktów
        public Wielobok(List<Punkt> points, string name)
        {
            Vertices = new List<Punkt>(points);
            Name = name;
        }

        //Dodaje wierzchołek do wieloboku
        public void AddVertex(Punkt p)
        {
            Vertices.Add(p);
        }

        //Przesuwa każdy wierzchołek o zadaną wartość
        public void Move(double dx, double dy)
        {
            foreach (var vertex in Vertices)
            {
                vertex.Move(dx, dy);
            }
        }

        //Oblicza obwód wieloboku jako sumę odległości między kolejnymi wierzchołkami
        public double GetCrc()
        {
            double perimeter = 0;
            for (int i = 0; i < Vertices.Count; i++)
            {
                var nextPoint = Vertices[(i + 1) % Vertices.Count];
                perimeter += Vertices[i].Distance(nextPoint);
            }
            return perimeter;
        }

        public override string ToString() => $"Wielobok {Name} z {Vertices.Count} wierzchołkami";

        #region ICloneable Members

        public Wielobok Clone()
        {
            List<Punkt> clonedVertices = new List<Punkt>();
            foreach (var vertex in Vertices)
            {
                clonedVertices.Add(vertex.Clone());
            }
            return new Wielobok(clonedVertices, Name);
        }

        object ICloneable.Clone() => Clone();

        #endregion

        public override bool Equals(object obj)
        {
            if (obj is Wielobok other && other.Vertices.Count == Vertices.Count)
            {
                for (int i = 0; i < Vertices.Count; i++)
                {
                    if (!Vertices[i].Equals(other.Vertices[i]))
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
