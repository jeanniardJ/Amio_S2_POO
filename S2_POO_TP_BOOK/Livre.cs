using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BOOK
{
    internal class Livre
    {
        public string Title { get; }

        private string LastName;

        private string FirstName;

        public string Author { get; }

        public float Sell { get; }

        public Livre(string title, string lastName, string firstname, float sell)
        {
            Title = title;
            LastName = lastName;
            FirstName = firstname;
            Author = firstname + " " + lastName;
            Sell = sell;
        }

        public void Afficher()
        {
            Console.WriteLine($"Title : {Title}, Author : {Author}, Sell : {Sell} ");
        }
    }
}
