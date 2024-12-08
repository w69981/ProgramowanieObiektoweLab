using System;

namespace Lab05_w69981
{
    internal class Punkt : ICloneable
    {
        private double x, y;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Punkt() { }

        public Punkt(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Punkt(Punkt other)
        {
            X = other.X;
            Y = other.Y;
        }

        #region ICloneable Members

        public Punkt Clone() => new Punkt(this);
        object ICloneable.Clone() => Clone();

        #endregion

        public virtual double GetCrc() => 0; //Obwód punktu to zawsze 0

        public virtual double Distance(Punkt p2)
        {
            return Math.Sqrt(Math.Pow(X - p2.X, 2) + Math.Pow(Y - p2.Y, 2));
        }

        public virtual void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public override string ToString() => $"Punkt: X={X}, Y={Y}";

        public override bool Equals(object obj)
        {
            return obj is Punkt punkt && X == punkt.X && Y == punkt.Y;
        }
    }
}
