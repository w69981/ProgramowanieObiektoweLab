namespace Lab02
{
    internal class BankAccount
    {
        private decimal saldo;
        private string wlasciciel;

        public BankAccount(string wlasciciel, decimal saldo)
        {
            this.Wlasciciel = wlasciciel;
            this.saldo = saldo;
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public string Wlasciciel
        {
            get { return wlasciciel; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Właściciel nie może być pusty.");
                }
                wlasciciel = value;
            }
        }

        public void Wplata(decimal kwota)
        {
            if (kwota <= 0)
                throw new ArgumentException("Kwota wpłaty musi być dodatnia.");

            saldo += kwota;
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota <= 0)
                throw new ArgumentException("Kwota wypłaty musi być dodatnia.");
            if (kwota > saldo)
                throw new ArgumentException("Niewystarczające środki na koncie.");

            saldo -= kwota;
        }
    }
}
