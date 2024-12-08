using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab02
{
    internal class Osoba
    {
        private string firstName;
        private string lastName;
        private int age;

        public Osoba(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //wlasciwosci
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 2)
                {
                    //Console.WriteLine($"Imie musi miec co najmniej dwa znaki");
                    throw new ArgumentException($"Imie musi miec co najmniej dwa znaki");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 2)
                {
                    //Console.WriteLine($"Imie musi miec co najmniej dwa znaki");
                    throw new ArgumentException($"Nazwisko musi miec co najmniej dwa znaki");
                }
                lastName = value;
            }
        }

        public int Age
        {
            get { return age; }

            set
            {
                if (age <= 0)
                {
                    throw new ArgumentException($"Wiek musi byc liczba dodatnia");
                    age = value;
                }
            }
        }


        public void View()
        {
            Console.WriteLine($"IMIE:{firstName}, NAZWISKO: {lastName}, WIEK: {age}");
        }











    }
}
