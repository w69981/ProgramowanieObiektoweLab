namespace Lab02
{
    internal class Sumator
    {
        private int[] liczby;

        public Sumator(int[] liczby)
        {
            this.liczby = liczby;
        }

        public int Suma()
        {
            int suma = 0;
            foreach (int liczba in liczby)
                suma += liczba;
            return suma;
        }

        public int SumaPodziel2()
        {
            int suma = 0;
            foreach (int liczba in liczby)
            {
                if (liczba % 2 == 0)
                    suma += liczba;
            }
            return suma;
        }

        public int IleElementow()
        {
            return liczby.Length;
        }

        public void View()
        {
            Console.WriteLine("Elementy tablicy:");
            foreach (int liczba in liczby)
            {
                Console.Write(liczba + " ");
            }
            Console.WriteLine();
        }

        public void ViewZakres(int lowIndex, int highIndex)
        {
            Console.WriteLine("Elementy w podanym zakresie:");
            for (int i = lowIndex; i <= highIndex; i++)
            {
                if (i >= 0 && i < liczby.Length)
                {
                    Console.Write(liczby[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
