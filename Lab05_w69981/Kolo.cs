using System;

namespace Lab05_w69981
{
    internal class Kolo : ICloneable
    {
        private Punkt center;
        private double radius;
        private string name;

        public Punkt Center { get => center; set => center = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Name { get => name; set => name = value; }

        public Kolo(double x, double y, double radius, string name)
        {
            Center = new Punkt(x, y);
            Radius = radius;
            Name = name;
        }

        public Kolo(Kolo other)
        {
            Center = other.Center.Clone();
            Radius = other.Radius;
            Name = other.Name;
        }

        public double GetCrc()
        {
            return 2 * Math.PI * Radius;
        }

        public void Move(double dx, double dy)
        {
            Center.Move(dx, dy);
        }

        #region ICloneable Members

        public Kolo Clone() => new Kolo(this);
        object ICloneable.Clone() => Clone();

        #endregion

        public override string ToString() => $"Koło {Name}: Środek = {Center}, Promień = {Radius}";

        public override bool Equals(object obj)
        {
            return obj is Kolo kolo && Center.Equals(kolo.Center) && Radius == kolo.Radius;
        }
    }
}
