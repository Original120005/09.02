using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_09._02._2023
{
    internal class InternationalPassport
    {
        private string number_of_pass;
        private string name;
        private string surname;
        private string date_of_issue;
        private string country;

        public InternationalPassport() { }
        public InternationalPassport(string nop, string n, string s, string date_of_issue, string country)
        {
            number_of_pass = nop;
            name = n;
            surname = s;
            this.date_of_issue = date_of_issue;
            this.country = country;
        }

        public void EnterPass()
        {
            int count = 0;
            while (count != 5)
            {
                try
                {
                    Console.Write("Enter number of passport: ");
                    number_of_pass = Console.ReadLine();
                    if (number_of_pass.Length != 8)
                    {
                        throw new Exception("Passport number consists of 8 characters!");
                    }
                    count++;

                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();
                    if (name.Length <= 1)
                    {
                        throw new Exception("Minimal amount words = 2!");
                    }
                    count++;

                    Console.Write("Enter your surname: ");
                    surname = Console.ReadLine();
                    if (surname.Length <= 2)
                    {
                        throw new Exception("Minimal amount words = 3!");
                    }
                    count++;

                    Console.Write("Enter date of issue: ");
                    date_of_issue = Console.ReadLine();
                    if (date_of_issue.Length != 8)
                    {
                        throw new Exception("Card expiration date must be eight-digit!");
                    }
                    count++;

                    Console.Write("Enter country: ");
                    country = Console.ReadLine();
                    if (country.Length <= 2)
                    {
                        throw new Exception("There is no such country!");
                    }
                    count++;
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); count = 0; }
            }
        }
        public void Print()
        {
            Console.WriteLine($"\nNumber of passport: {number_of_pass}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Date of issue: {date_of_issue}");
            Console.WriteLine($"Country: {country}");
        }

    }
}