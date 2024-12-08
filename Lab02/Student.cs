namespace Lab02
{
    internal class Student
    {
        private string imie;
        private string nazwisko;
        private List<int> oceny;

        public Student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            oceny = new List<int>();
        }

        public string Imie
        {
            get { return imie; }
            set
            {
                if (value.Length < 2)
                    throw new ArgumentException("Imię musi mieć co najmniej dwa znaki.");
                imie = value;
            }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (value.Length < 2)
                    throw new ArgumentException("Nazwisko musi mieć co najmniej dwa znaki.");
                nazwisko = value;
            }
        }

        public double SredniaOcen
        {
            get
            {
                if (oceny.Count == 0)
                    return 0;
                int suma = 0;
                foreach (int ocena in oceny)
                    suma += ocena;
                return (double)suma / oceny.Count;
            }
        }

        public void DodajOcene(int ocena)
        {
            if (ocena < 1 || ocena > 6)
                throw new ArgumentException("Ocena musi być w przedziale 1-6.");
            oceny.Add(ocena);
        }

        public void View()
        {
            Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Średnia ocen: {SredniaOcen:F2}");
        }
    }
}
