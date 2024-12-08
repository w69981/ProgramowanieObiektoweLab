using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get => firstName;
            set => firstName = value.Length > 0 ? value : throw new ArgumentException("First name cannot be empty");
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value.Length > 0 ? value : throw new ArgumentException("Last name cannot be empty");
        }

        public int Age
        {
            get => age;
            set => age = value > 0 ? value : throw new ArgumentException("Age must be positive");
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual string View()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}
