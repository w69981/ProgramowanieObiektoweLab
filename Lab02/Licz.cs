namespace Lab02
{
    internal class Licz
    {
        private int value;

        public Licz(int initialValue)
        {
            value = initialValue;
        }

        public void Dodaj(int liczba)
        {
            value += liczba;
        }

        public void Odejmij(int liczba)
        {
            value -= liczba;
        }

        public void View()
        {
            Console.WriteLine($"Aktualna wartość: {value}");
        }
    }
}
