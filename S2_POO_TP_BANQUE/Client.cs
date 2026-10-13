using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BANQUE
{
    internal class Client
    {
        public string CIN { get; }

        public string LastName { get; }
        
        public string FirstName { get; }

        public string Tel { get; }

        //public Client() { }

        public Client(string cin, string lastName, string firstName, string tel)
        {
            CIN = cin;
            LastName = lastName;
            FirstName = firstName;
            Tel = tel;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Le client a pour numéro de réf : {CIN}\n\t- {LastName}\n\t- {FirstName}\n\t- {Tel}");
        }
    }
}
