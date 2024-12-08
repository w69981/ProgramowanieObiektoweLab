using System;

namespace Lab05_w69981
{
    internal class Trojkat : ICloneable
    {
        private Punkt a, b, c;
        private string name;

        public Punkt A { get => a; set => a = value; }
        public Punkt B { get => b; set => b = value; }
        public Punkt C { get => c; set => c = value; }
        public string Name { get => name; set => name = value; }

        public Trojkat(Punkt a, Punkt b, Punkt c, string name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.name = name;
        }

        public double GetCrc()
        {
            //Obwód trójkąta to suma odległości między wierzchołkami
            return a.Distance(b) + b.Distance(c) + c.Distance(a);
        }

        public void Move(double dx, double dy)
        {
            //Przesuwa każdy wierzchołek o zadaną wartość
            a.Move(dx, dy);
            b.Move(dx, dy);
            c.Move(dx, dy);
        }

        public override string ToString()
        {
            return $"Trójkąt {Name}: Wierzchołki A {a}, B {b}, C {c}";
        }

        #region ICloneable Members

        public Trojkat Clone()
        {
            //Tworzy kopię trójkąta z kopiami punktów A, B i C
            return new Trojkat(a.Clone(), b.Clone(), c.Clone(), Name);
        }

        object ICloneable.Clone() => Clone();

        #endregion

        public override bool Equals(object obj)
        {
            //Porównuje trójkąty poprzez ich wierzchołki
            return obj is Trojkat trojkat && a.Equals(trojkat.A) && b.Equals(trojkat.B) && c.Equals(trojkat.C);
        }
    }
}
